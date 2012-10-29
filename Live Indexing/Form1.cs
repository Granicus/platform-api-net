using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LiveIndexing
{
    public partial class Form1 : Form
    {
        private bool _running;

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
                Running = false;
            }
            else
            {
                Application.Exit();
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            outcastencoder.StopMeeting();
            outcastencoder.Disconnect();
            Running = false;
        }

        private void recordButton_Click(object sender, EventArgs e)
        {
            if (indexItemBox.Checked)
            {
                outcastencoder.RecordItem(itemTextBox.Text, foreignIdBox.ValidateText().ToString());
            }
            else
            {
                outcastencoder.RecordNonIndexedItem(itemTextBox.Text, foreignIdBox.ValidateText().ToString());
            }
            foreignIdBox.Text = (((int)foreignIdBox.ValidateText()) + 1).ToString(); // increment the foreignId
            itemTextBox.Text = "";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            OpenMeetingDialog openmeetingdialog = new OpenMeetingDialog(mediamanager);
            DialogResult result = openmeetingdialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                outcastencoder = openmeetingdialog.Encoder;
                outcastencoder.LoadMeeting(openmeetingdialog.DocumentID);
                outcastencoder.StartMeeting();
                Running = true;
            }
        }

        private bool Running
        {
            set
            {
                startButton.Enabled = !value;
                stopButton.Enabled = value;
                recordButton.Enabled = value;
                itemTextBox.Enabled = value;
                foreignIdBox.Enabled = value;
                getStatusButton.Enabled = value;
                extendMeetingButton.Enabled = value;
                pauseMeetingButton.Enabled = value;
                _running = value;
            }
            get
            {
                return _running;
            }
        }

        private void getStatusButton_Click(object sender, EventArgs e)
        {
            EncoderStatusDialog dialog = new EncoderStatusDialog(outcastencoder);
            dialog.ShowDialog();
        }

        private void extendMeetingButton_Click(object sender, EventArgs e)
        {
            ExtendMeetingDialog dialog = new ExtendMeetingDialog(outcastencoder);
            dialog.ShowDialog();
        }

        private void pauseMeetingButton_Click(object sender, EventArgs e)
        {
            if (pauseMeetingButton.Text == "Pause Meeting")
            {
                outcastencoder.PauseMeeting();
                pauseMeetingButton.Text = "Un-Pause Meeting";
            }
            else
            {
                outcastencoder.StartMeeting();
                pauseMeetingButton.Text = "Pause Meeting";
            }
        }
    }
}
