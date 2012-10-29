namespace MeetingSimulator
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
            this.mediamanager = new Granicus.MediaManager.SDK.MediaManager();
            this.eventListView = new System.Windows.Forms.ListView();
            this.runButton = new System.Windows.Forms.Button();
            this.idColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.nameColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.uploadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // mediamanager
            // 
            this.mediamanager.CookieContainer = ((System.Net.CookieContainer)(resources.GetObject("mediamanager.CookieContainer")));
            this.mediamanager.Credentials = null;
            this.mediamanager.Url = "http://javiervista/SDK/User/index.php";
            this.mediamanager.UseDefaultCredentials = false;
            // 
            // eventListView
            // 
            this.eventListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumnHeader,
            this.nameColumnHeader});
            this.eventListView.FullRowSelect = true;
            this.eventListView.Location = new System.Drawing.Point(12, 12);
            this.eventListView.MultiSelect = false;
            this.eventListView.Name = "eventListView";
            this.eventListView.Size = new System.Drawing.Size(587, 417);
            this.eventListView.TabIndex = 0;
            this.eventListView.UseCompatibleStateImageBehavior = false;
            this.eventListView.View = System.Windows.Forms.View.Details;
            this.eventListView.SelectedIndexChanged += new System.EventHandler(this.eventListView_SelectedIndexChanged);
            // 
            // runButton
            // 
            this.runButton.Enabled = false;
            this.runButton.Location = new System.Drawing.Point(439, 435);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(160, 23);
            this.runButton.TabIndex = 1;
            this.runButton.Text = "Run Simulation";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // idColumnHeader
            // 
            this.idColumnHeader.Text = "Event ID";
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Event Name";
            this.nameColumnHeader.Width = 517;
            // 
            // uploadFileDialog
            // 
            this.uploadFileDialog.Filter = "Video Files|*.wmv";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 470);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.eventListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Meeting Simulator Sample Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Granicus.MediaManager.SDK.MediaManager mediamanager;
        private System.Windows.Forms.ListView eventListView;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.ColumnHeader idColumnHeader;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.OpenFileDialog uploadFileDialog;
    }
}

