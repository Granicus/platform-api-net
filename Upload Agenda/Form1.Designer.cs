namespace UploadAgenda
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
            this.idHeader = new System.Windows.Forms.ColumnHeader();
            this.nameHeader = new System.Windows.Forms.ColumnHeader();
            this.dateHeader = new System.Windows.Forms.ColumnHeader();
            this.newEventButton = new System.Windows.Forms.Button();
            this.uploadAgendaButton = new System.Windows.Forms.Button();
            this.agendaFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.refreshButton = new System.Windows.Forms.Button();
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
            this.eventListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.eventListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idHeader,
            this.nameHeader,
            this.dateHeader});
            this.eventListView.FullRowSelect = true;
            this.eventListView.Location = new System.Drawing.Point(12, 12);
            this.eventListView.MultiSelect = false;
            this.eventListView.Name = "eventListView";
            this.eventListView.Size = new System.Drawing.Size(537, 390);
            this.eventListView.TabIndex = 0;
            this.eventListView.UseCompatibleStateImageBehavior = false;
            this.eventListView.View = System.Windows.Forms.View.Details;
            this.eventListView.SelectedIndexChanged += new System.EventHandler(this.eventListView_SelectedIndexChanged);
            // 
            // idHeader
            // 
            this.idHeader.Text = "Event ID";
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Event Name";
            this.nameHeader.Width = 334;
            // 
            // dateHeader
            // 
            this.dateHeader.Text = "Event Date";
            this.dateHeader.Width = 139;
            // 
            // newEventButton
            // 
            this.newEventButton.Location = new System.Drawing.Point(12, 408);
            this.newEventButton.Name = "newEventButton";
            this.newEventButton.Size = new System.Drawing.Size(82, 23);
            this.newEventButton.TabIndex = 2;
            this.newEventButton.Text = "New Event";
            this.newEventButton.UseVisualStyleBackColor = true;
            this.newEventButton.Click += new System.EventHandler(this.newEventButton_Click);
            // 
            // uploadAgendaButton
            // 
            this.uploadAgendaButton.Enabled = false;
            this.uploadAgendaButton.Location = new System.Drawing.Point(430, 408);
            this.uploadAgendaButton.Name = "uploadAgendaButton";
            this.uploadAgendaButton.Size = new System.Drawing.Size(119, 23);
            this.uploadAgendaButton.TabIndex = 3;
            this.uploadAgendaButton.Text = "Upload Agenda";
            this.uploadAgendaButton.UseVisualStyleBackColor = true;
            this.uploadAgendaButton.Click += new System.EventHandler(this.uploadAgendaButton_Click);
            // 
            // agendaFileDialog
            // 
            this.agendaFileDialog.FileName = "agenda.xml";
            this.agendaFileDialog.Filter = "XML Files|*.xml|All Files|*.*";
            this.agendaFileDialog.Title = "Load Agenda XML";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(100, 408);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(82, 23);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Refresh List";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 441);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.uploadAgendaButton);
            this.Controls.Add(this.newEventButton);
            this.Controls.Add(this.eventListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Upload Agenda Sample Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Granicus.MediaManager.SDK.MediaManager mediamanager;
        private System.Windows.Forms.ListView eventListView;
        private System.Windows.Forms.ColumnHeader idHeader;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader dateHeader;
        private System.Windows.Forms.Button newEventButton;
        private System.Windows.Forms.Button uploadAgendaButton;
        private System.Windows.Forms.OpenFileDialog agendaFileDialog;
        private System.Windows.Forms.Button refreshButton;
    }
}

