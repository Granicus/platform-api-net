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
    public partial class ExtendMeetingDialog : Form
    {
        public ExtendMeetingDialog(OutcastEncoder encoder)
        {
            InitializeComponent();
            outcastencoder = encoder;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExtendButton_Click(object sender, EventArgs e)
        {
            int seconds = Int16.Parse(secondsTextBox.Text);
            outcastencoder.ExtendMeeting(seconds);
            this.Close();
        }
    }
}
