namespace LiveIndexing
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.foreignIdBox = new System.Windows.Forms.MaskedTextBox();
            this.recordButton = new System.Windows.Forms.Button();
            this.mediamanager = new Granicus.MediaManager.SDK.MediaManager();
            this.outcastencoder = new Granicus.MediaManager.SDK.OutcastEncoder();
            this.indexItemBox = new System.Windows.Forms.CheckBox();
            this.getStatusButton = new System.Windows.Forms.Button();
            this.pauseMeetingButton = new System.Windows.Forms.Button();
            this.extendMeetingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(555, 325);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(129, 23);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "Stop Meeting";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 325);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(129, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start Meeting";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // itemTextBox
            // 
            this.itemTextBox.Enabled = false;
            this.itemTextBox.Location = new System.Drawing.Point(12, 25);
            this.itemTextBox.Multiline = true;
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.Size = new System.Drawing.Size(672, 175);
            this.itemTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item Text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Foreign ID:";
            // 
            // foreignIdBox
            // 
            this.foreignIdBox.Enabled = false;
            this.foreignIdBox.Location = new System.Drawing.Point(78, 207);
            this.foreignIdBox.Mask = "99999";
            this.foreignIdBox.Name = "foreignIdBox";
            this.foreignIdBox.Size = new System.Drawing.Size(42, 20);
            this.foreignIdBox.TabIndex = 6;
            this.foreignIdBox.Text = "1";
            this.foreignIdBox.ValidatingType = typeof(int);
            // 
            // recordButton
            // 
            this.recordButton.Enabled = false;
            this.recordButton.Location = new System.Drawing.Point(555, 210);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(129, 23);
            this.recordButton.TabIndex = 2;
            this.recordButton.Text = "Record Item";
            this.recordButton.UseVisualStyleBackColor = true;
            this.recordButton.Click += new System.EventHandler(this.recordButton_Click);
            // 
            // mediamanager
            // 
            this.mediamanager.CookieContainer = ((System.Net.CookieContainer)(resources.GetObject("mediamanager.CookieContainer")));
            this.mediamanager.Credentials = null;
            this.mediamanager.Url = "http://javiervista/SDK/User/index.php";
            this.mediamanager.UseDefaultCredentials = false;
            // 
            // outcastencoder
            // 
            this.outcastencoder.Credentials = null;
            this.outcastencoder.Url = "http://10.100.0.32/outcast/meetingserverwebservice.asmx";
            this.outcastencoder.UseDefaultCredentials = false;
            // 
            // indexItemBox
            // 
            this.indexItemBox.AutoSize = true;
            this.indexItemBox.Checked = true;
            this.indexItemBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.indexItemBox.Location = new System.Drawing.Point(471, 214);
            this.indexItemBox.Name = "indexItemBox";
            this.indexItemBox.Size = new System.Drawing.Size(75, 17);
            this.indexItemBox.TabIndex = 7;
            this.indexItemBox.Text = "Index Item";
            this.indexItemBox.UseVisualStyleBackColor = true;
            // 
            // getStatusButton
            // 
            this.getStatusButton.Enabled = false;
            this.getStatusButton.Location = new System.Drawing.Point(417, 325);
            this.getStatusButton.Name = "getStatusButton";
            this.getStatusButton.Size = new System.Drawing.Size(129, 23);
            this.getStatusButton.TabIndex = 8;
            this.getStatusButton.Text = "Get Status";
            this.getStatusButton.UseVisualStyleBackColor = true;
            this.getStatusButton.Click += new System.EventHandler(this.getStatusButton_Click);
            // 
            // pauseMeetingButton
            // 
            this.pauseMeetingButton.Location = new System.Drawing.Point(147, 325);
            this.pauseMeetingButton.Name = "pauseMeetingButton";
            this.pauseMeetingButton.Size = new System.Drawing.Size(129, 23);
            this.pauseMeetingButton.TabIndex = 9;
            this.pauseMeetingButton.Text = "Pause Meeting";
            this.pauseMeetingButton.UseVisualStyleBackColor = true;
            this.pauseMeetingButton.Click += new System.EventHandler(this.pauseMeetingButton_Click);
            // 
            // extendMeetingButton
            // 
            this.extendMeetingButton.Location = new System.Drawing.Point(282, 325);
            this.extendMeetingButton.Name = "extendMeetingButton";
            this.extendMeetingButton.Size = new System.Drawing.Size(129, 23);
            this.extendMeetingButton.TabIndex = 10;
            this.extendMeetingButton.Text = "Extend Meeting";
            this.extendMeetingButton.UseVisualStyleBackColor = true;
            this.extendMeetingButton.Click += new System.EventHandler(this.extendMeetingButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 360);
            this.Controls.Add(this.extendMeetingButton);
            this.Controls.Add(this.pauseMeetingButton);
            this.Controls.Add(this.getStatusButton);
            this.Controls.Add(this.indexItemBox);
            this.Controls.Add(this.recordButton);
            this.Controls.Add(this.foreignIdBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemTextBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.stopButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Live Indexing Sample Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Granicus.MediaManager.SDK.MediaManager mediamanager;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox foreignIdBox;
        private System.Windows.Forms.Button recordButton;
        private Granicus.MediaManager.SDK.OutcastEncoder outcastencoder;
        private System.Windows.Forms.CheckBox indexItemBox;
        private System.Windows.Forms.Button getStatusButton;
        private System.Windows.Forms.Button pauseMeetingButton;
        private System.Windows.Forms.Button extendMeetingButton;
    }
}

