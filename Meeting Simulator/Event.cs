using Granicus.MediaManager.SDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MeetingSimulator
{
    public partial class Event : Form
    {
        private MediaManager _mediaManager;

        private int _eventDetailsCounter = 0;


        private List<int> _eventIds = new List<int>();
        private List<int> _folderIds = new List<int>();
        private List<int> _cameraIds = new List<int>();

        private int _eventId = 0;   
        private int _folderId = 0;
        private int _cameraId = 0;

        public Event()
        {
            InitializeComponent();
        }

        private void Event_Load(object sender, EventArgs e)
        {
            MediaManager mediaManager = new MediaManager();
            LoginForm login = new LoginForm(mediaManager);
            login.StartPosition = FormStartPosition.CenterScreen;

            DialogResult result = login.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (mediaManager.Connected)
                {
                    _mediaManager = mediaManager;
                }
            }
            else
            {
                MessageBox.Show("Failed to connect to MediaManager", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            if (_mediaManager != null)
            {
                SetDefaultEventDetails();
                this.txtStatus.Text = String.Format("-- Connected to Media Manager: {0}", _mediaManager.Url);

            }
            else
            {
                MessageBox.Show("-- Login unsuccessful! Closing the app.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void SetDefaultEventDetails()
        {
            _eventDetailsCounter++;
            var now = DateTime.Now;
            this.txtEventName.Text = string.Format("{0} - Simulator Test Event - {1}", _eventDetailsCounter, now.ToString("g"));
            this.txtEventDate.Text = now.ToString("g");
            this.txtLinkedVideoStreamUrl.Text = "https://friendly.new.swagit.com/events/xyz";
        }

        private EventData CreateTestEvent(string eventName, DateTime eventTime, string eventLinkedVideoStreamUrl = "")
        {
            EventData ret = null;

            var folder = CreateTestFolder();
            var camera = CreateTestCamera();
            _folderId = folder.ID;
            _cameraId = camera.ID; 

            var newEvent = new EventData();
            newEvent.Name = eventName;
            newEvent.MeetingTime = eventTime;
            newEvent.StartTime = eventTime;
            newEvent.CameraID = camera.ID;
            newEvent.FolderID = folder.ID;

            newEvent.Duration = 2 * 60 * 60;
            newEvent.Record = true;
            newEvent.Broadcast = true;

            newEvent.LinkedVideoStreamUrl = eventLinkedVideoStreamUrl;

            _eventId = _mediaManager.CreateEvent(newEvent);
            ret = _mediaManager.GetEvent(_eventId);

            _eventIds.Add(_eventId);

            return ret;
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            string strMsg = string.Empty;   
            DateTime eventDate;

            if (!DateTime.TryParse(txtEventDate.Text, out eventDate))
            {
                MessageBox.Show("Invalid date format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EventData testEvent = null;

            try
            {
                testEvent = CreateTestEvent(txtEventName.Text, eventDate, txtLinkedVideoStreamUrl.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("An error occurred while creating Event: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (testEvent != null)
            {
                strMsg = String.Format("-- Event Created: {0} - {1}", testEvent.Name, testEvent.ID);
                this.txtStatus.Text += String.Format("{0}{1}", Environment.NewLine, strMsg);
                MessageBox.Show(strMsg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // re-set defaults for another event creation
                SetDefaultEventDetails();
            }
            else
            {
                strMsg = "-- Event creation failed!";
                this.txtStatus.Text += String.Format("{0}{1}", Environment.NewLine, strMsg);
                MessageBox.Show(strMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private CameraData CreateTestCamera()
        {
            CameraData camera = null;

                var cameraID = _mediaManager.CreateCamera(new CameraData()
                {
                    Name = "test camera",
                    Type = "Meeting"
                });
                camera = _mediaManager.GetCamera(cameraID);

            return camera;
        }

        private FolderData CreateTestFolder()
        {
            FolderData folder = null;

            var folderID = _mediaManager.CreateFolder(new FolderData()
            {
                Name = "test folder",
                Description = "test folder",
                Type = "Meeting"
            });
            folder = _mediaManager.GetFolder(folderID);

            return folder;
        }

        private void Event_FormClosed(object sender, System.EventArgs e)
        {
            // cleanup: remove created Events, then Folders and Cameras

            if (_eventIds != null && _eventIds.Count > 0)
            {
                foreach (var eventId in _eventIds)
                {
                    _mediaManager.DeleteEvent(eventId);
                }
            }   

            if (_cameraIds != null && _cameraIds.Count > 0)
            {
                foreach (var cameraId in _cameraIds)
                {
                    _mediaManager.DeleteCamera(cameraId);
                }
            }   

            if (_folderIds != null && _folderIds.Count > 0)
            {
                foreach (var folderId in _folderIds)
                {
                    _mediaManager.DeleteFolder(folderId);
                }
            }
        }
    }
}
