namespace UploadAgenda
{
    partial class CreateEvent
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
            this.autoStartCheckBox = new System.Windows.Forms.CheckBox();
            this.eventNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.templateBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cameraBox = new System.Windows.Forms.ComboBox();
            this.createEventButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.foreignIdBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.startTimeBox = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.durationBox = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.archiveStatusBox = new System.Windows.Forms.ComboBox();
            this.broadcastCheckBox = new System.Windows.Forms.CheckBox();
            this.recordCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.zipBox = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.stateBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.street2Box = new System.Windows.Forms.TextBox();
            this.street1Box = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // autoStartCheckBox
            // 
            this.autoStartCheckBox.AutoSize = true;
            this.autoStartCheckBox.Location = new System.Drawing.Point(136, 127);
            this.autoStartCheckBox.Name = "autoStartCheckBox";
            this.autoStartCheckBox.Size = new System.Drawing.Size(73, 17);
            this.autoStartCheckBox.TabIndex = 14;
            this.autoStartCheckBox.Text = "Auto Start";
            this.autoStartCheckBox.UseVisualStyleBackColor = true;
            // 
            // eventNameBox
            // 
            this.eventNameBox.Location = new System.Drawing.Point(138, 27);
            this.eventNameBox.Name = "eventNameBox";
            this.eventNameBox.Size = new System.Drawing.Size(369, 20);
            this.eventNameBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Event Name:";
            // 
            // templateBox
            // 
            this.templateBox.FormattingEnabled = true;
            this.templateBox.Location = new System.Drawing.Point(136, 100);
            this.templateBox.Name = "templateBox";
            this.templateBox.Size = new System.Drawing.Size(370, 21);
            this.templateBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Player Template:";
            // 
            // folderBox
            // 
            this.folderBox.FormattingEnabled = true;
            this.folderBox.Location = new System.Drawing.Point(138, 46);
            this.folderBox.Name = "folderBox";
            this.folderBox.Size = new System.Drawing.Size(370, 21);
            this.folderBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Archive Folder:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Camera:";
            // 
            // cameraBox
            // 
            this.cameraBox.FormattingEnabled = true;
            this.cameraBox.Location = new System.Drawing.Point(137, 19);
            this.cameraBox.Name = "cameraBox";
            this.cameraBox.Size = new System.Drawing.Size(370, 21);
            this.cameraBox.TabIndex = 10;
            // 
            // createEventButton
            // 
            this.createEventButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.createEventButton.Location = new System.Drawing.Point(299, 492);
            this.createEventButton.Name = "createEventButton";
            this.createEventButton.Size = new System.Drawing.Size(109, 23);
            this.createEventButton.TabIndex = 24;
            this.createEventButton.Text = "Create";
            this.createEventButton.UseVisualStyleBackColor = true;
            this.createEventButton.Click += new System.EventHandler(this.createEventButton_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(414, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Foreign ID:";
            // 
            // foreignIdBox
            // 
            this.foreignIdBox.Location = new System.Drawing.Point(138, 53);
            this.foreignIdBox.Name = "foreignIdBox";
            this.foreignIdBox.Size = new System.Drawing.Size(369, 20);
            this.foreignIdBox.TabIndex = 2;
            this.foreignIdBox.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.startTimeBox);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.durationBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.foreignIdBox);
            this.groupBox1.Controls.Add(this.eventNameBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 141);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Properties";
            // 
            // startTimeBox
            // 
            this.startTimeBox.Location = new System.Drawing.Point(138, 79);
            this.startTimeBox.Mask = "00/00/0000 90:00";
            this.startTimeBox.Name = "startTimeBox";
            this.startTimeBox.Size = new System.Drawing.Size(102, 20);
            this.startTimeBox.TabIndex = 3;
            this.startTimeBox.Text = "101020101230";
            this.startTimeBox.ValidatingType = typeof(System.DateTime);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(74, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Start Time:";
            // 
            // durationBox
            // 
            this.durationBox.Location = new System.Drawing.Point(138, 105);
            this.durationBox.Mask = "90:00";
            this.durationBox.Name = "durationBox";
            this.durationBox.Size = new System.Drawing.Size(47, 20);
            this.durationBox.TabIndex = 4;
            this.durationBox.Text = "0100";
            this.durationBox.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Duration:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.archiveStatusBox);
            this.groupBox2.Controls.Add(this.broadcastCheckBox);
            this.groupBox2.Controls.Add(this.recordCheckBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.folderBox);
            this.groupBox2.Controls.Add(this.autoStartCheckBox);
            this.groupBox2.Controls.Add(this.templateBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cameraBox);
            this.groupBox2.Location = new System.Drawing.Point(11, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 165);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Archiving and Playback Settings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Archive Status (after upload):";
            // 
            // archiveStatusBox
            // 
            this.archiveStatusBox.FormattingEnabled = true;
            this.archiveStatusBox.Items.AddRange(new object[] {
            "Pending",
            "Public",
            "Not Public"});
            this.archiveStatusBox.Location = new System.Drawing.Point(156, 73);
            this.archiveStatusBox.Name = "archiveStatusBox";
            this.archiveStatusBox.Size = new System.Drawing.Size(96, 21);
            this.archiveStatusBox.TabIndex = 12;
            // 
            // broadcastCheckBox
            // 
            this.broadcastCheckBox.AutoSize = true;
            this.broadcastCheckBox.Location = new System.Drawing.Point(282, 127);
            this.broadcastCheckBox.Name = "broadcastCheckBox";
            this.broadcastCheckBox.Size = new System.Drawing.Size(74, 17);
            this.broadcastCheckBox.TabIndex = 16;
            this.broadcastCheckBox.Text = "Broadcast";
            this.broadcastCheckBox.UseVisualStyleBackColor = true;
            // 
            // recordCheckBox
            // 
            this.recordCheckBox.AutoSize = true;
            this.recordCheckBox.Location = new System.Drawing.Point(215, 127);
            this.recordCheckBox.Name = "recordCheckBox";
            this.recordCheckBox.Size = new System.Drawing.Size(61, 17);
            this.recordCheckBox.TabIndex = 15;
            this.recordCheckBox.Text = "Record";
            this.recordCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.zipBox);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.stateBox);
            this.groupBox3.Controls.Add(this.cityBox);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.street2Box);
            this.groupBox3.Controls.Add(this.street1Box);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(11, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(513, 156);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Event Location";
            // 
            // zipBox
            // 
            this.zipBox.Location = new System.Drawing.Point(138, 124);
            this.zipBox.Mask = "00000";
            this.zipBox.Name = "zipBox";
            this.zipBox.Size = new System.Drawing.Size(71, 20);
            this.zipBox.TabIndex = 9;
            this.zipBox.Text = "94105";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(104, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "City:";
            // 
            // stateBox
            // 
            this.stateBox.Location = new System.Drawing.Point(137, 97);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(28, 20);
            this.stateBox.TabIndex = 8;
            this.stateBox.Text = "CA";
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(137, 71);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(369, 20);
            this.cityBox.TabIndex = 7;
            this.cityBox.Text = "San Francisco";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(96, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "State:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Zip:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Street 1:";
            // 
            // street2Box
            // 
            this.street2Box.Location = new System.Drawing.Point(137, 45);
            this.street2Box.Name = "street2Box";
            this.street2Box.Size = new System.Drawing.Size(369, 20);
            this.street2Box.TabIndex = 6;
            this.street2Box.Text = "Suite 300";
            // 
            // street1Box
            // 
            this.street1Box.Location = new System.Drawing.Point(137, 19);
            this.street1Box.Name = "street1Box";
            this.street1Box.Size = new System.Drawing.Size(369, 20);
            this.street1Box.TabIndex = 5;
            this.street1Box.Text = "568 Howard Street";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(84, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Street 2:";
            // 
            // CreateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 527);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.createEventButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CreateEvent";
            this.Text = "Create Event";
            this.Load += new System.EventHandler(this.CreateEvent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox autoStartCheckBox;
        private System.Windows.Forms.TextBox eventNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox templateBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox folderBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cameraBox;
        private System.Windows.Forms.Button createEventButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox foreignIdBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox broadcastCheckBox;
        private System.Windows.Forms.CheckBox recordCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox archiveStatusBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox street2Box;
        private System.Windows.Forms.TextBox street1Box;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox stateBox;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox durationBox;
        private System.Windows.Forms.MaskedTextBox zipBox;
        private System.Windows.Forms.MaskedTextBox startTimeBox;
        private System.Windows.Forms.Label label13;
    }
}