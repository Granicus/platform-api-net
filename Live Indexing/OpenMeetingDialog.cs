using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Granicus.MediaManager.SDK;

namespace LiveIndexing
{
    public partial class OpenMeetingDialog : Form
    {
        private OutcastEncoder _outcast;
        private string _documentId;
        private CameraData[] _cameras;

        public OutcastEncoder Encoder
        {
            get
            {
                return _outcast;
            }
        }

        public string DocumentID
        {
            get
            {
                return _documentId;
            }
        }

        private MediaManager _mediamanager;

        public OpenMeetingDialog(MediaManager mediamanager)
        {
            InitializeComponent();
            _mediamanager = mediamanager;
        }

        private void OpenMeetingDialog_Load(object sender, EventArgs e)
        {
            _cameras = _mediamanager.GetCameras();
            cameraBox.Items.Clear();
            foreach (CameraData camera in _cameras)
            {
                cameraBox.Items.Add(camera.Name);
            }
            cameraBox.SelectedIndex = 0;
        }

        private void cameraBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _outcast = _mediamanager.GetOutcastEncoder(_cameras[cameraBox.SelectedIndex]);
            MeetingDocumentHeader[] documentheaders = _outcast.GetDocuments();
            meetingListView.Items.Clear();
            foreach (MeetingDocumentHeader header in documentheaders)
            {
                string[] itemdetails = { header.DocumentID, header.DocumentName };
                ListViewItem item = new ListViewItem(itemdetails);
                meetingListView.Items.Add(item);
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            _documentId = meetingListView.SelectedItems[0].Text;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void meetingListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (meetingListView.SelectedItems.Count > 0)
            {
                openButton.Enabled = true;
            }
            else
            {
                openButton.Enabled = false;
            }
        }
    }
}
