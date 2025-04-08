namespace MeetingSimulator
{
    partial class Event
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
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.txtEventDate = new System.Windows.Forms.TextBox();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblLinkedVideoStreamUrl = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.txtLinkedVideoStreamUrl = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.pnlEvent = new System.Windows.Forms.Panel();
            this.lblCaption = new System.Windows.Forms.Label();
            this.pnlEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Location = new System.Drawing.Point(358, 169);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(90, 23);
            this.btnCreateEvent.TabIndex = 7;
            this.btnCreateEvent.Text = "Create";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Location = new System.Drawing.Point(96, 63);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(61, 13);
            this.lblEventDate.TabIndex = 1;
            this.lblEventDate.Text = "Event Date";
            // 
            // txtEventDate
            // 
            this.txtEventDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEventDate.Location = new System.Drawing.Point(163, 63);
            this.txtEventDate.Name = "txtEventDate";
            this.txtEventDate.Size = new System.Drawing.Size(285, 20);
            this.txtEventDate.TabIndex = 2;
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Location = new System.Drawing.Point(91, 97);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(66, 13);
            this.lblEventName.TabIndex = 3;
            this.lblEventName.Text = "Event Name";
            // 
            // lblLinkedVideoStreamUrl
            // 
            this.lblLinkedVideoStreamUrl.AutoSize = true;
            this.lblLinkedVideoStreamUrl.Location = new System.Drawing.Point(27, 133);
            this.lblLinkedVideoStreamUrl.Name = "lblLinkedVideoStreamUrl";
            this.lblLinkedVideoStreamUrl.Size = new System.Drawing.Size(130, 13);
            this.lblLinkedVideoStreamUrl.TabIndex = 5;
            this.lblLinkedVideoStreamUrl.Text = "Linked Video Stream URL";
            // 
            // txtEventName
            // 
            this.txtEventName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEventName.Location = new System.Drawing.Point(163, 94);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(285, 20);
            this.txtEventName.TabIndex = 4;
            // 
            // txtLinkedVideoStreamUrl
            // 
            this.txtLinkedVideoStreamUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLinkedVideoStreamUrl.Location = new System.Drawing.Point(163, 130);
            this.txtLinkedVideoStreamUrl.Name = "txtLinkedVideoStreamUrl";
            this.txtLinkedVideoStreamUrl.Size = new System.Drawing.Size(285, 20);
            this.txtLinkedVideoStreamUrl.TabIndex = 6;
            // 
            // txtStatus
            // 
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatus.Location = new System.Drawing.Point(37, 210);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStatus.Size = new System.Drawing.Size(411, 67);
            this.txtStatus.TabIndex = 8;
            // 
            // pnlEvent
            // 
            this.pnlEvent.AccessibleDescription = "Event Panel UI element";
            this.pnlEvent.AccessibleName = "Event Panel";
            this.pnlEvent.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.pnlEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEvent.Controls.Add(this.lblCaption);
            this.pnlEvent.Controls.Add(this.txtLinkedVideoStreamUrl);
            this.pnlEvent.Controls.Add(this.txtStatus);
            this.pnlEvent.Controls.Add(this.btnCreateEvent);
            this.pnlEvent.Controls.Add(this.lblEventDate);
            this.pnlEvent.Controls.Add(this.txtEventName);
            this.pnlEvent.Controls.Add(this.txtEventDate);
            this.pnlEvent.Controls.Add(this.lblLinkedVideoStreamUrl);
            this.pnlEvent.Controls.Add(this.lblEventName);
            this.pnlEvent.Location = new System.Drawing.Point(12, 12);
            this.pnlEvent.Name = "pnlEvent";
            this.pnlEvent.Size = new System.Drawing.Size(471, 290);
            this.pnlEvent.TabIndex = 9;
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(95, 19);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(296, 24);
            this.lblCaption.TabIndex = 9;
            this.lblCaption.Text = "Create Test MediaManager Event ";
            // 
            // Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 317);
            this.Controls.Add(this.pnlEvent);
            this.Name = "Event";
            this.Text = "Event";
            this.Closed += new System.EventHandler(this.Event_FormClosed);
            this.Load += new System.EventHandler(this.Event_Load);
            this.pnlEvent.ResumeLayout(false);
            this.pnlEvent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.TextBox txtEventDate;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblLinkedVideoStreamUrl;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.TextBox txtLinkedVideoStreamUrl;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Panel pnlEvent;
        private System.Windows.Forms.Label lblCaption;
        private Granicus.MediaManager.SDK.MediaManager mediamanager;
    }
}