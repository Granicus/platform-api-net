namespace LiveIndexing
{
    partial class EncoderStatusDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.outcastencoder = new Granicus.MediaManager.SDK.OutcastEncoder();
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.agendaDocumentId = new System.Windows.Forms.TextBox();
            this.archiveDuration = new System.Windows.Forms.TextBox();
            this.archiveFileName = new System.Windows.Forms.TextBox();
            this.archiveState = new System.Windows.Forms.TextBox();
            this.encoderState = new System.Windows.Forms.TextBox();
            this.masterDocumentId = new System.Windows.Forms.TextBox();
            this.meetingName = new System.Windows.Forms.TextBox();
            this.meetingTimeElapsed = new System.Windows.Forms.TextBox();
            this.meetingTimerState = new System.Windows.Forms.TextBox();
            this.minutesDocumentId = new System.Windows.Forms.TextBox();
            this.archiveFolderId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.connectedToMeetingServer = new System.Windows.Forms.CheckBox();
            this.suspendRecordItem = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // outcastencoder
            // 
            this.outcastencoder.Credentials = null;
            this.outcastencoder.Url = "http://10.100.0.32/outcast/meetingserverwebservice.asmx";
            this.outcastencoder.UseDefaultCredentials = false;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(312, 381);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "AgendaDocumentID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ArchiveDuration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ArchiveFileName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "ArchiveState";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "EncoderState";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "MasterDocumentID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "MeetingName";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "MeetingTimeElapsed";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "MeetingTimerState";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "MinutesDocumentID";
            // 
            // agendaDocumentId
            // 
            this.agendaDocumentId.Enabled = false;
            this.agendaDocumentId.Location = new System.Drawing.Point(124, 12);
            this.agendaDocumentId.Name = "agendaDocumentId";
            this.agendaDocumentId.Size = new System.Drawing.Size(263, 20);
            this.agendaDocumentId.TabIndex = 12;
            // 
            // archiveDuration
            // 
            this.archiveDuration.Enabled = false;
            this.archiveDuration.Location = new System.Drawing.Point(124, 64);
            this.archiveDuration.Name = "archiveDuration";
            this.archiveDuration.Size = new System.Drawing.Size(155, 20);
            this.archiveDuration.TabIndex = 13;
            // 
            // archiveFileName
            // 
            this.archiveFileName.Enabled = false;
            this.archiveFileName.Location = new System.Drawing.Point(124, 90);
            this.archiveFileName.Name = "archiveFileName";
            this.archiveFileName.Size = new System.Drawing.Size(231, 20);
            this.archiveFileName.TabIndex = 14;
            // 
            // archiveState
            // 
            this.archiveState.Enabled = false;
            this.archiveState.Location = new System.Drawing.Point(124, 116);
            this.archiveState.Name = "archiveState";
            this.archiveState.Size = new System.Drawing.Size(125, 20);
            this.archiveState.TabIndex = 15;
            // 
            // encoderState
            // 
            this.encoderState.Enabled = false;
            this.encoderState.Location = new System.Drawing.Point(124, 142);
            this.encoderState.Name = "encoderState";
            this.encoderState.Size = new System.Drawing.Size(125, 20);
            this.encoderState.TabIndex = 17;
            // 
            // masterDocumentId
            // 
            this.masterDocumentId.Enabled = false;
            this.masterDocumentId.Location = new System.Drawing.Point(124, 168);
            this.masterDocumentId.Name = "masterDocumentId";
            this.masterDocumentId.Size = new System.Drawing.Size(231, 20);
            this.masterDocumentId.TabIndex = 18;
            // 
            // meetingName
            // 
            this.meetingName.Enabled = false;
            this.meetingName.Location = new System.Drawing.Point(124, 194);
            this.meetingName.Name = "meetingName";
            this.meetingName.Size = new System.Drawing.Size(263, 20);
            this.meetingName.TabIndex = 19;
            // 
            // meetingTimeElapsed
            // 
            this.meetingTimeElapsed.Enabled = false;
            this.meetingTimeElapsed.Location = new System.Drawing.Point(124, 220);
            this.meetingTimeElapsed.Name = "meetingTimeElapsed";
            this.meetingTimeElapsed.Size = new System.Drawing.Size(90, 20);
            this.meetingTimeElapsed.TabIndex = 20;
            // 
            // meetingTimerState
            // 
            this.meetingTimerState.Enabled = false;
            this.meetingTimerState.Location = new System.Drawing.Point(124, 246);
            this.meetingTimerState.Name = "meetingTimerState";
            this.meetingTimerState.Size = new System.Drawing.Size(90, 20);
            this.meetingTimerState.TabIndex = 21;
            // 
            // minutesDocumentId
            // 
            this.minutesDocumentId.Enabled = false;
            this.minutesDocumentId.Location = new System.Drawing.Point(124, 272);
            this.minutesDocumentId.Name = "minutesDocumentId";
            this.minutesDocumentId.Size = new System.Drawing.Size(263, 20);
            this.minutesDocumentId.TabIndex = 22;
            // 
            // archiveFolderId
            // 
            this.archiveFolderId.Enabled = false;
            this.archiveFolderId.Location = new System.Drawing.Point(124, 38);
            this.archiveFolderId.Name = "archiveFolderId";
            this.archiveFolderId.Size = new System.Drawing.Size(155, 20);
            this.archiveFolderId.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "ArchiveFolderID";
            // 
            // connectedToMeetingServer
            // 
            this.connectedToMeetingServer.AutoSize = true;
            this.connectedToMeetingServer.Enabled = false;
            this.connectedToMeetingServer.Location = new System.Drawing.Point(124, 299);
            this.connectedToMeetingServer.Name = "connectedToMeetingServer";
            this.connectedToMeetingServer.Size = new System.Drawing.Size(160, 17);
            this.connectedToMeetingServer.TabIndex = 25;
            this.connectedToMeetingServer.Text = "ConnectedToMeetingServer";
            this.connectedToMeetingServer.UseVisualStyleBackColor = true;
            // 
            // suspendRecordItem
            // 
            this.suspendRecordItem.AutoSize = true;
            this.suspendRecordItem.Location = new System.Drawing.Point(124, 322);
            this.suspendRecordItem.Name = "suspendRecordItem";
            this.suspendRecordItem.Size = new System.Drawing.Size(123, 17);
            this.suspendRecordItem.TabIndex = 26;
            this.suspendRecordItem.Text = "SuspendRecordItem";
            this.suspendRecordItem.UseVisualStyleBackColor = true;
            this.suspendRecordItem.CheckedChanged += new System.EventHandler(this.suspendRecordItem_CheckedChanged);
            // 
            // EncoderStatusDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 416);
            this.Controls.Add(this.suspendRecordItem);
            this.Controls.Add(this.connectedToMeetingServer);
            this.Controls.Add(this.archiveFolderId);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.minutesDocumentId);
            this.Controls.Add(this.meetingTimerState);
            this.Controls.Add(this.meetingTimeElapsed);
            this.Controls.Add(this.meetingName);
            this.Controls.Add(this.masterDocumentId);
            this.Controls.Add(this.encoderState);
            this.Controls.Add(this.archiveState);
            this.Controls.Add(this.archiveFileName);
            this.Controls.Add(this.archiveDuration);
            this.Controls.Add(this.agendaDocumentId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EncoderStatusDialog";
            this.Text = "Encoder Status";
            this.Load += new System.EventHandler(this.EncoderStatusDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Granicus.MediaManager.SDK.OutcastEncoder outcastencoder;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox agendaDocumentId;
        private System.Windows.Forms.TextBox archiveDuration;
        private System.Windows.Forms.TextBox archiveFileName;
        private System.Windows.Forms.TextBox archiveState;
        private System.Windows.Forms.TextBox encoderState;
        private System.Windows.Forms.TextBox masterDocumentId;
        private System.Windows.Forms.TextBox meetingName;
        private System.Windows.Forms.TextBox meetingTimeElapsed;
        private System.Windows.Forms.TextBox meetingTimerState;
        private System.Windows.Forms.TextBox minutesDocumentId;
        private System.Windows.Forms.TextBox archiveFolderId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox connectedToMeetingServer;
        private System.Windows.Forms.CheckBox suspendRecordItem;
    }
}