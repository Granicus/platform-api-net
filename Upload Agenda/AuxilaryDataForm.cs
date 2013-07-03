using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Granicus.MediaManager.SDK;
using System.Text.RegularExpressions;

namespace UploadAgenda
{
    public partial class AuxilaryDataForm : Form
    {
        MediaManager _mediamanager;
        Attendee _attendee;


        public AuxilaryDataForm(MediaManager mediamanager)
        {
            _mediamanager = mediamanager;
            InitializeComponent();

            InitCamerasListView();
        }

        private void updateMotionActionsButton_Click(object sender, EventArgs e)
        {
            StringCollection s = new StringCollection();

            if (this.motionActionsTextBox.Text != String.Empty)
            {
                string[] words = Regex.Split(this.motionActionsTextBox.Text, "\r\n");

                if (words != null)
                    foreach (string verb in words)
                        s.Add(verb);

                _mediamanager.CreateMotionActions(s);
            }
            else
            {
                MessageBox.Show("No motion actions on the list.");
            }

            MessageBox.Show("Successfully sent motion action list.");
        }
 
        private void createAttendeeButton_Click(object sender, EventArgs e)
        {
            Attendee[] attendees = new Attendee[2];
            _attendee = new Attendee();

            _attendee.Name = personNameTextBox.Text;
            _attendee.PersonUID = personUIDTextBox.Text; //todo: test GUID's validity
            _attendee.Voting = false;
            _attendee.Chair = false;

            Attendee attendee1 = new Attendee();

            attendee1.Name = "Guid likePerson";
            attendee1.PersonUID = Guid.NewGuid().ToString();
            attendee1.Voting = false;
            attendee1.Chair = false;

            attendees[0] = _attendee;
            attendees[1] = attendee1;
            _mediamanager.CreateAttendees(attendees);
            MessageBox.Show("Attendees were created successfully.");
        }

        private void getMotionActions_Click(object sender, EventArgs e)
        {
            // Clear old text
            motionActionsTextBox.Clear();

            StringCollection motionActions = _mediamanager.GetMotionActions();
            String textBoxText = String.Empty;

            foreach (String verb in motionActions)
                textBoxText += verb + "\r\n";

            motionActionsTextBox.Text = textBoxText;

            MessageBox.Show("Successfully got motion action list.");
        }

        private void clearMotionActions_Click(object sender, EventArgs e)
        {
            motionActionsTextBox.Clear();
        }

        private void launchLiveManagerButton_Click(object sender, EventArgs e)
        {
            if (cameraListView.SelectedItems != null && cameraListView.SelectedItems.Count > 0)
            {
                ListViewItem svi = cameraListView.SelectedItems[0];

                string liveManagerUrlTemplate = @"http://{0}:{1}/livemanager/LiveManager.application?meetingserverip={0}&webserviceport={1}";
                string launchString = string.Empty;

                launchString = string.Format(liveManagerUrlTemplate, svi.SubItems[3].Text, svi.SubItems[5].Text);

                //MessageBox.Show("Launch this URL: " + launchString);
                System.Diagnostics.Process.Start("IExplore.exe", launchString);
            }
            else
            {
                MessageBox.Show("Please select an encoder/camera!");
            }
        }

        private void InitCamerasListView()
        {
            CameraData[] cameras = _mediamanager.GetCameras();
            cameraListView.Items.Clear();

            foreach (CameraData cd in cameras)
            {
                string[] values = { cd.ID.ToString(), cd.Name, cd.Identifier, cd.InternalIP, cd.ExternalIP, cd.ControlPort.ToString() };
                ListViewItem lvi = new ListViewItem(values);

                cameraListView.Items.Add(lvi);
            }
        }

    }
}
