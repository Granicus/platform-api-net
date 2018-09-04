namespace UploadAgenda
{
    partial class AuxilaryDataForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.createAttendeeButton = new System.Windows.Forms.Button();
            this.personUIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.personNameTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.clearMotionActions = new System.Windows.Forms.Button();
            this.getMotionActions = new System.Windows.Forms.Button();
            this.updateMotionActionsButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.motionActionsTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.launchLiveManagerButton = new System.Windows.Forms.Button();
            this.cameraListView = new System.Windows.Forms.ListView();
            this.idColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.identifierColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.internalIPColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.externalIPColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.controlPortColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.settingsTextBox = new System.Windows.Forms.TextBox();
            this.clearSettingsButton = new System.Windows.Forms.Button();
            this.getSettingsButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(511, 362);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.createAttendeeButton);
            this.tabPage1.Controls.Add(this.personUIDTextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.personNameTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(503, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Attendees";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // createAttendeeButton
            // 
            this.createAttendeeButton.Location = new System.Drawing.Point(245, 239);
            this.createAttendeeButton.Name = "createAttendeeButton";
            this.createAttendeeButton.Size = new System.Drawing.Size(104, 23);
            this.createAttendeeButton.TabIndex = 4;
            this.createAttendeeButton.Text = "Create attendee";
            this.createAttendeeButton.UseVisualStyleBackColor = true;
            this.createAttendeeButton.Click += new System.EventHandler(this.createAttendeeButton_Click);
            // 
            // personUIDTextBox
            // 
            this.personUIDTextBox.Location = new System.Drawing.Point(84, 56);
            this.personUIDTextBox.Name = "personUIDTextBox";
            this.personUIDTextBox.Size = new System.Drawing.Size(253, 20);
            this.personUIDTextBox.TabIndex = 3;
            this.personUIDTextBox.Text = "00000000-0000-0000-0000-000000000001";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Person UID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // personNameTextBox
            // 
            this.personNameTextBox.Location = new System.Drawing.Point(48, 32);
            this.personNameTextBox.Name = "personNameTextBox";
            this.personNameTextBox.Size = new System.Drawing.Size(289, 20);
            this.personNameTextBox.TabIndex = 0;
            this.personNameTextBox.Text = "Some Person";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.clearMotionActions);
            this.tabPage2.Controls.Add(this.getMotionActions);
            this.tabPage2.Controls.Add(this.updateMotionActionsButton);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.motionActionsTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(503, 336);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Motion Actions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // clearMotionActions
            // 
            this.clearMotionActions.Location = new System.Drawing.Point(56, 236);
            this.clearMotionActions.Name = "clearMotionActions";
            this.clearMotionActions.Size = new System.Drawing.Size(54, 23);
            this.clearMotionActions.TabIndex = 4;
            this.clearMotionActions.Text = "Clear";
            this.clearMotionActions.UseVisualStyleBackColor = true;
            this.clearMotionActions.Click += new System.EventHandler(this.clearMotionActions_Click);
            // 
            // getMotionActions
            // 
            this.getMotionActions.Location = new System.Drawing.Point(116, 236);
            this.getMotionActions.Name = "getMotionActions";
            this.getMotionActions.Size = new System.Drawing.Size(103, 23);
            this.getMotionActions.TabIndex = 3;
            this.getMotionActions.Text = "Get motion actions";
            this.getMotionActions.UseVisualStyleBackColor = true;
            this.getMotionActions.Click += new System.EventHandler(this.getMotionActions_Click);
            // 
            // updateMotionActionsButton
            // 
            this.updateMotionActionsButton.Location = new System.Drawing.Point(225, 236);
            this.updateMotionActionsButton.Name = "updateMotionActionsButton";
            this.updateMotionActionsButton.Size = new System.Drawing.Size(112, 23);
            this.updateMotionActionsButton.TabIndex = 2;
            this.updateMotionActionsButton.Text = "Send motion actions";
            this.updateMotionActionsButton.UseVisualStyleBackColor = true;
            this.updateMotionActionsButton.Click += new System.EventHandler(this.updateMotionActionsButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Motion actions:";
            // 
            // motionActionsTextBox
            // 
            this.motionActionsTextBox.Location = new System.Drawing.Point(94, 21);
            this.motionActionsTextBox.Multiline = true;
            this.motionActionsTextBox.Name = "motionActionsTextBox";
            this.motionActionsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.motionActionsTextBox.Size = new System.Drawing.Size(243, 192);
            this.motionActionsTextBox.TabIndex = 0;
            this.motionActionsTextBox.Text = "approve\r\ncontinue\r\nreject\r\ntable\r\nfree form\r\npostpone\r\nconsent\r\nfilibuster";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.launchLiveManagerButton);
            this.tabPage3.Controls.Add(this.cameraListView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(503, 336);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cameras/Encoders";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // launchLiveManagerButton
            // 
            this.launchLiveManagerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.launchLiveManagerButton.Location = new System.Drawing.Point(359, 305);
            this.launchLiveManagerButton.Name = "launchLiveManagerButton";
            this.launchLiveManagerButton.Size = new System.Drawing.Size(136, 23);
            this.launchLiveManagerButton.TabIndex = 1;
            this.launchLiveManagerButton.Text = "Launch LiveManager";
            this.launchLiveManagerButton.UseVisualStyleBackColor = true;
            this.launchLiveManagerButton.Click += new System.EventHandler(this.launchLiveManagerButton_Click);
            // 
            // cameraListView
            // 
            this.cameraListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.cameraListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumnHeader,
            this.nameColumnHeader,
            this.identifierColumnHeader,
            this.internalIPColumnHeader,
            this.externalIPColumnHeader,
            this.controlPortColumnHeader});
            this.cameraListView.Dock = System.Windows.Forms.DockStyle.Top;
            this.cameraListView.FullRowSelect = true;
            this.cameraListView.Location = new System.Drawing.Point(0, 0);
            this.cameraListView.MultiSelect = false;
            this.cameraListView.Name = "cameraListView";
            this.cameraListView.Size = new System.Drawing.Size(503, 274);
            this.cameraListView.TabIndex = 0;
            this.cameraListView.UseCompatibleStateImageBehavior = false;
            this.cameraListView.View = System.Windows.Forms.View.Details;
            // 
            // idColumnHeader
            // 
            this.idColumnHeader.Text = "ID";
            this.idColumnHeader.Width = 30;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.Width = 80;
            // 
            // identifierColumnHeader
            // 
            this.identifierColumnHeader.Text = "Identifier";
            this.identifierColumnHeader.Width = 80;
            // 
            // internalIPColumnHeader
            // 
            this.internalIPColumnHeader.Text = "InternalIP";
            this.internalIPColumnHeader.Width = 80;
            // 
            // externalIPColumnHeader
            // 
            this.externalIPColumnHeader.Text = "ExternalIP";
            this.externalIPColumnHeader.Width = 80;
            // 
            // controlPortColumnHeader
            // 
            this.controlPortColumnHeader.Text = "Control port";
            this.controlPortColumnHeader.Width = 70;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.getSettingsButton);
            this.tabPage4.Controls.Add(this.clearSettingsButton);
            this.tabPage4.Controls.Add(this.settingsTextBox);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(503, 336);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Settings";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Settings:";
            // 
            // settingsTextBox
            // 
            this.settingsTextBox.Location = new System.Drawing.Point(90, 22);
            this.settingsTextBox.Multiline = true;
            this.settingsTextBox.Name = "settingsTextBox";
            this.settingsTextBox.Size = new System.Drawing.Size(316, 218);
            this.settingsTextBox.TabIndex = 1;
            // 
            // clearSettingsButton
            // 
            this.clearSettingsButton.Location = new System.Drawing.Point(197, 268);
            this.clearSettingsButton.Name = "clearSettingsButton";
            this.clearSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.clearSettingsButton.TabIndex = 2;
            this.clearSettingsButton.Text = "Clear";
            this.clearSettingsButton.UseVisualStyleBackColor = true;
            this.clearSettingsButton.Click += new System.EventHandler(this.clearSettingsButton_Click);
            // 
            // getSettingsButton
            // 
            this.getSettingsButton.Location = new System.Drawing.Point(314, 268);
            this.getSettingsButton.Name = "getSettingsButton";
            this.getSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.getSettingsButton.TabIndex = 3;
            this.getSettingsButton.Text = "Get Settings";
            this.getSettingsButton.UseVisualStyleBackColor = true;
            this.getSettingsButton.Click += new System.EventHandler(this.getSettingsButton_Click);
            // 
            // AuxilaryDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 362);
            this.Controls.Add(this.tabControl1);
            this.Name = "AuxilaryDataForm";
            this.Text = "AuxilaryDataForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button createAttendeeButton;
        private System.Windows.Forms.TextBox personUIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox personNameTextBox;
        private System.Windows.Forms.Button updateMotionActionsButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox motionActionsTextBox;
        private System.Windows.Forms.Button clearMotionActions;
        private System.Windows.Forms.Button getMotionActions;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView cameraListView;
        private System.Windows.Forms.Button launchLiveManagerButton;
        private System.Windows.Forms.ColumnHeader idColumnHeader;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader identifierColumnHeader;
        private System.Windows.Forms.ColumnHeader internalIPColumnHeader;
        private System.Windows.Forms.ColumnHeader externalIPColumnHeader;
        private System.Windows.Forms.ColumnHeader controlPortColumnHeader;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button getSettingsButton;
        private System.Windows.Forms.Button clearSettingsButton;
        private System.Windows.Forms.TextBox settingsTextBox;
        private System.Windows.Forms.Label label4;
    }
}