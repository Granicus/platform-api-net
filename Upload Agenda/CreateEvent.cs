using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Granicus.MediaManager.SDK;

namespace UploadAgenda
{
    public partial class CreateEvent : Form
    {
        private MediaManager _mediamanager;
        private bool _success = false;
        private FolderData[] _folders;
        private CameraData[] _cameras;
        private TemplateData[] _templates;

        private int _EventID;

        public int EventID
        {
            get
            {
                return _EventID;
            }
        }
        
        public CreateEvent(MediaManager mediamanager)
        {
            _mediamanager = mediamanager;
            InitializeComponent();
        }

        public bool Success
        {
            get
            {
                return _success;
            }
        }

        private void CreateEvent_Load(object sender, EventArgs e)
        {
            _folders = _mediamanager.GetFolders();
            foreach (FolderData folder in _folders)
            {
                folderBox.Items.Add(folder.Name);
            }
            folderBox.SelectedIndex = 0;

            _cameras = _mediamanager.GetCameras();
            foreach (CameraData cam in _cameras)
            {
                cameraBox.Items.Add(cam.Name);
            }
            cameraBox.SelectedIndex = 0;

            _templates = _mediamanager.GetTemplates();
            foreach (TemplateData template in _templates)
            {
                if (template.Type.ToLower() == "player")
                {
                    templateBox.Items.Add(template.Name);
                }
            }
            templateBox.SelectedIndex = 0;

            archiveStatusBox.SelectedIndex = 0;
        }

        private void createEventButton_Click(object sender, EventArgs e)
        {
            EventData myevent = new EventData(0,
                null,
                Int32.Parse(foreignIdBox.Text),
                eventNameBox.Text,
                _cameras[cameraBox.SelectedIndex].ID,
                _folders[folderBox.SelectedIndex].ID,
                null,
                null,
                null,
                _templates[templateBox.SelectedIndex].ID,
                archiveStatusBox.SelectedItem.ToString(),
                (int) DateTime.Parse(durationBox.Text).TimeOfDay.TotalSeconds,
                broadcastCheckBox.Checked,
                recordCheckBox.Checked,
                autoStartCheckBox.Checked,
                DateTime.Parse(startTimeBox.Text),
                DateTime.Now,
                null,
                null,
                street1Box.Text,
                street2Box.Text,
                cityBox.Text,
                stateBox.Text,
                zipBox.Text,
                eventNameBox.Text,
                DateTime.Parse (startTimeBox.Text),
                DateTime.Now,
                consentAgendaCheckBox.Checked ? 1 : 0);
            _EventID = _mediamanager.CreateEvent(myevent);
            this._success = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
