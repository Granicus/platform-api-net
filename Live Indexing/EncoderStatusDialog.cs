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
    public partial class EncoderStatusDialog : Form
    {
        public EncoderStatusDialog(OutcastEncoder encoder)
        {
            InitializeComponent();
            outcastencoder = encoder;
        }

        private void EncoderStatusDialog_Load(object sender, EventArgs e)
        {
            EncoderStatus status = outcastencoder.GetStatus();
            agendaDocumentId.Text = status.AgendaDocumentID;
            archiveDuration.Text = status.ArchiveDuration.ToString();
            archiveFileName.Text = status.ArchiveFileName;
            archiveFolderId.Text = status.ArchiveFolderID.ToString();
            archiveState.Text = status.ArchiveState;
            encoderState.Text = status.EncoderState;
            masterDocumentId.Text = status.MasterDocumentID;
            meetingName.Text = status.MeetingName;
            meetingTimeElapsed.Text = status.MeetingTimeElapsed.ToString();
            meetingTimerState.Text = status.MeetingTimerState;
            minutesDocumentId.Text = status.MinutesDocumentID;
            connectedToMeetingServer.Checked = status.ConnectedToMeetingServer;
            suspendRecordItem.Checked = status.SuspendRecordItem;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void suspendRecordItem_CheckedChanged(object sender, EventArgs e)
        {
            outcastencoder.SetSuspendRecordItem(suspendRecordItem.Checked);
        }
    }
}
