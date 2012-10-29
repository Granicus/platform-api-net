using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Granicus.MediaManager.SDK;
using System.IO;
using System.Threading;

namespace UploadVideo
{
    public partial class UploadProgressDialog : Form
    {
        private int defaultChunkSize;
        private int folderId;
        private string currentFile;
        private long currentPosition;
        private string[] fileList;
        private string currentBucket;
        private MediaVault mediaVault;
        public UploadProgressDialog(string[] files, MediaVault mediavault, int folderid, int chunksize)
        {
            InitializeComponent();
            fileList = files;
            mediaVault = mediavault;
            defaultChunkSize = chunksize;
            folderId = folderid;
            
            uploadFileBackgroundWorker.ProgressChanged += new ProgressChangedEventHandler(uploadFileBackgroundWorker_ProgressChanged);
            uploadFileBackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(uploadFileBackgroundWorker_RunWorkerCompleted);
        }

        void uploadFileBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("Transfer failed: " + e.Error.Message);
            }
            else if(e.Cancelled)
            {
                MessageBox.Show("Upload cancelled!");
            }
            else
            {
                MessageBox.Show((string)e.Result);
            }
            this.Close();
        }

        void uploadFileBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            statusLabel.Text = "Uploading " + currentFile + "...";
            uploadProgressBar.Value = e.ProgressPercentage;
        }

        private void UploadProgressDialog_Load(object sender, EventArgs e)
        {
            uploadFileBackgroundWorker.RunWorkerAsync(fileList);
        }

        private void uploadFileBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] files = (string[]) e.Argument;
            foreach (string file in files)
            {
                FileStream fs = new FileStream(file, FileMode.Open,FileAccess.Read);
                BinaryReader reader = new BinaryReader(fs);
                long size = new FileInfo(file).Length;
                if (size == 0) continue;
                currentPosition = 0;
                int chunksize = defaultChunkSize;
                currentBucket = mediaVault.StartUpload();
                currentFile = new FileInfo(file).Name;
                while (currentPosition < size)
                {
                    // background worker implementation details
                    uploadFileBackgroundWorker.ReportProgress((int)(((double)currentPosition / (double)size) * 100));
                    if (uploadFileBackgroundWorker.CancellationPending)
                    {
                        mediaVault.AbortUpload(currentBucket);
                        e.Cancel = true;
                        return;
                    }

                    // send chunk implementation
                    reader.BaseStream.Seek(currentPosition, SeekOrigin.Begin);
                    if (chunksize > (size - currentPosition))
                    {
                        chunksize = (int)(size - currentPosition);
                    }
                    byte[] chunk = new byte[chunksize];
                    reader.Read(chunk,0,chunksize);
                    try
                    {
                        mediaVault.SendChunk(currentBucket, currentPosition, chunk);
                        currentPosition += chunksize;
                    }
                    catch (Exception)
                    {
                        // we want to retry on any other exception thrown by SendChunk()
                    }
                }
                uploadFileBackgroundWorker.ReportProgress(100);
                // the entire file transferred, so register it with MediaManager and move on to the next file
                mediaVault.FinishUpload(currentBucket);
                string extension = new FileInfo(file).Extension;
                mediaVault.RegisterUploadedFile(currentBucket, folderId, currentFile.TrimEnd(("." + extension).ToCharArray()), extension);
            }
            e.Result = files.Length + " file(s) uploaded successfully.";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            uploadFileBackgroundWorker.CancelAsync();
        }
    }
}
