using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Granicus.MediaManager.SDK;
using System.IO;

namespace UploadVideo
{
    public partial class Form1 : Form
    {
        private MediaManager mediamanager;
        public Form1()
        {
            InitializeComponent();
            mediamanager = new MediaManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm(mediamanager);
            DialogResult result = login.ShowDialog();
            if (result == DialogResult.OK)
            {
                FolderData[] folders = mediamanager.GetFolders();
                foreach (FolderData folder in folders)
                {
                    String[] details = {folder.ID.ToString(),folder.Name,folder.Description};
                    ListViewItem item = new ListViewItem(details);
                    folderListView.Items.Add(item);
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void folderListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (folderListView.SelectedItems.Count > 0)
            {
                uploadButton.Enabled = true;
            }
            else
            {
                uploadButton.Enabled = false;
            }
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            DialogResult result = uploadFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                int folderId = Int32.Parse(folderListView.SelectedItems[0].Text);
                MediaVault mv = mediamanager.GetMediaVault(folderId);
                UploadProgressDialog uploadProgressDialog = new UploadProgressDialog(uploadFileDialog.FileNames,mv,folderId,512 * 512);
                uploadProgressDialog.ShowDialog();
            }
        }
    }
}
