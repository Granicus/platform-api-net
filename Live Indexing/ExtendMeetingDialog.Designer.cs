namespace LiveIndexing
{
    partial class ExtendMeetingDialog
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
            this.secondsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExtendButton = new System.Windows.Forms.Button();
            this.CancellationButton = new System.Windows.Forms.Button();
            this.outcastencoder = new Granicus.MediaManager.SDK.OutcastEncoder();
            this.SuspendLayout();
            // 
            // secondsTextBox
            // 
            this.secondsTextBox.Enabled = false;
            this.secondsTextBox.Location = new System.Drawing.Point(89, 6);
            this.secondsTextBox.Name = "secondsTextBox";
            this.secondsTextBox.Size = new System.Drawing.Size(184, 20);
            this.secondsTextBox.TabIndex = 14;
            this.secondsTextBox.Text = "300";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "# of Seconds";
            // 
            // ExtendButton
            // 
            this.ExtendButton.Location = new System.Drawing.Point(198, 60);
            this.ExtendButton.Name = "ExtendButton";
            this.ExtendButton.Size = new System.Drawing.Size(75, 23);
            this.ExtendButton.TabIndex = 15;
            this.ExtendButton.Text = "Extend";
            this.ExtendButton.UseVisualStyleBackColor = true;
            this.ExtendButton.Click += new System.EventHandler(this.ExtendButton_Click);
            // 
            // CancelButton
            // 
            this.CancellationButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancellationButton.Location = new System.Drawing.Point(12, 60);
            this.CancellationButton.Name = "CancelButton";
            this.CancellationButton.Size = new System.Drawing.Size(75, 23);
            this.CancellationButton.TabIndex = 16;
            this.CancellationButton.Text = "Cancel";
            this.CancellationButton.UseVisualStyleBackColor = true;
            this.CancellationButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // outcastencoder
            // 
            this.outcastencoder.Credentials = null;
            this.outcastencoder.Url = "http://10.100.0.32/outcast/meetingserverwebservice.asmx";
            this.outcastencoder.UseDefaultCredentials = false;
            // 
            // ExtendMeetingDialog
            // 
            this.AcceptButton = this.ExtendButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 95);
            this.Controls.Add(this.CancellationButton);
            this.Controls.Add(this.ExtendButton);
            this.Controls.Add(this.secondsTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ExtendMeetingDialog";
            this.Text = "Extend Meeting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox secondsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExtendButton;
        private System.Windows.Forms.Button CancellationButton;
        private Granicus.MediaManager.SDK.OutcastEncoder outcastencoder;
    }
}