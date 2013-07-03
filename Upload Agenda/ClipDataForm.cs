using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Granicus.MediaManager.SDK;

namespace UploadAgenda
{
    public partial class ClipDataForm : Form
    {
        MediaManager _mediamanager;

        public ClipDataForm(MediaManager mediaManager)
        {
            _mediamanager = mediaManager;
            InitializeComponent();
        }

        private void getClipByClipIDButton_Click(object sender, EventArgs e)
        {
            int clipID = 187;
            MetaDataData[] clipMetadata = _mediamanager.GetClipMetaData(clipID);

            string msg = string.Format("Retrieved {0} metadata record(s) for ClipID={1}{2}{2}", clipMetadata.Length, clipID, Environment.NewLine);

            for (int i = 0; i < clipMetadata.Length; i++)
            {
                if (clipMetadata[i].ConsentVoteUID != string.Empty)
                {
                    msg += string.Format("Metadata item[{0}] with UID={1} has ConsentVoteGUID of [{2}]", i, clipMetadata[i].UID, clipMetadata[i].ConsentVoteUID);
                    break;
                }
            }

            MessageBox.Show(msg);
        }
    }
}
