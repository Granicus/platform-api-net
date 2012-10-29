namespace LiveIndexing
{
    partial class OpenMeetingDialog
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.meetingListView = new System.Windows.Forms.ListView();
            this.documentIdColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.meetingNameColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.cameraBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(494, 371);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // openButton
            // 
            this.openButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.openButton.Enabled = false;
            this.openButton.Location = new System.Drawing.Point(413, 371);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // meetingListView
            // 
            this.meetingListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.documentIdColumnHeader,
            this.meetingNameColumnHeader});
            this.meetingListView.FullRowSelect = true;
            this.meetingListView.Location = new System.Drawing.Point(12, 40);
            this.meetingListView.MultiSelect = false;
            this.meetingListView.Name = "meetingListView";
            this.meetingListView.Size = new System.Drawing.Size(557, 325);
            this.meetingListView.TabIndex = 2;
            this.meetingListView.UseCompatibleStateImageBehavior = false;
            this.meetingListView.View = System.Windows.Forms.View.Details;
            this.meetingListView.SelectedIndexChanged += new System.EventHandler(this.meetingListView_SelectedIndexChanged);
            // 
            // documentIdColumnHeader
            // 
            this.documentIdColumnHeader.Text = "Document ID";
            this.documentIdColumnHeader.Width = 228;
            // 
            // meetingNameColumnHeader
            // 
            this.meetingNameColumnHeader.Text = "Meeting Name";
            this.meetingNameColumnHeader.Width = 322;
            // 
            // cameraBox
            // 
            this.cameraBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cameraBox.FormattingEnabled = true;
            this.cameraBox.Location = new System.Drawing.Point(413, 13);
            this.cameraBox.Name = "cameraBox";
            this.cameraBox.Size = new System.Drawing.Size(155, 21);
            this.cameraBox.TabIndex = 3;
            this.cameraBox.SelectedIndexChanged += new System.EventHandler(this.cameraBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Encoder:";
            // 
            // OpenMeetingDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 406);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cameraBox);
            this.Controls.Add(this.meetingListView);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OpenMeetingDialog";
            this.Text = "Select a Meeting:";
            this.Load += new System.EventHandler(this.OpenMeetingDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.ListView meetingListView;
        private System.Windows.Forms.ComboBox cameraBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader documentIdColumnHeader;
        private System.Windows.Forms.ColumnHeader meetingNameColumnHeader;
    }
}