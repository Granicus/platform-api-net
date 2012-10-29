using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Granicus.MediaManager.SDK;

namespace MeetingSimulator
{
    public partial class Form1 : Form
    {
        EventData[] _events;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm(mediamanager);
            DialogResult result = login.ShowDialog();
            if (result == DialogResult.OK)
            {
                _events = mediamanager.GetEvents();
                foreach (EventData eventdata in _events)
                {
                    string[] details = { eventdata.ID.ToString(), eventdata.Name };
                    ListViewItem item = new ListViewItem(details);
                    eventListView.Items.Add(item);
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void eventListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eventListView.SelectedItems.Count > 0)
            {
                runButton.Enabled = true;
            }
            else
            {
                runButton.Enabled = false;
            }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = uploadFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    EventData sim_event = _events[eventListView.SelectedIndices[0]];

                    MediaVault mv = mediamanager.GetMediaVault(sim_event.FolderID);
                    UploadProgressDialog uploadProgressDialog = new UploadProgressDialog(uploadFileDialog.FileNames, mv, sim_event.FolderID, 512 * 512);
                    uploadProgressDialog.ShowDialog();

                    // update the new archive's properties to match the event
                    int clipId = uploadProgressDialog.ArchiveIDs[0];
                    ClipData clip = mediamanager.GetClip(clipId);
                    clip.Name = sim_event.Name;
                    clip.ForeignID = sim_event.ForeignID;
                    clip.Date = sim_event.StartTime;
                    clip.StartTime = sim_event.StartTime;
                    clip.Attendees = sim_event.Attendees;
                    clip.AgendaFile = sim_event.AgendaFile;
                    clip.AgendaType = sim_event.AgendaType;
                    clip.Status = sim_event.ArchiveStatus;
                    clip.Street1 = sim_event.Street1;
                    clip.Street2 = sim_event.Street2;
                    clip.City = sim_event.City;
                    clip.State = sim_event.State;
                    clip.Zip = sim_event.Zip;
                    clip.CameraID = sim_event.CameraID;
                    mediamanager.UpdateClip(clip);

                    // transfer the event metadata to the clip
                    MetaDataData[] meta_array = mediamanager.GetEventMetaData(sim_event.ID);

                    // scrub out the UIDs and assign source_id
                    foreach (MetaDataData meta in meta_array)
                    {
                        meta.SourceID = meta.ID;
                        meta.UID = "";
                    }

                    // tree-ify
                    mediamanager.ConvertToMetaTree(ref meta_array);

                    // upload metadata into the archive
                    mediamanager.ImportClipMetaData(clipId, meta_array, true, true);

                    MessageBox.Show("Meeting simulated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Simulation failed, please make sure your MediaManager site is properly configured and running at least version 3.5.");
            }
        }

        
    }
}
