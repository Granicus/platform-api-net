using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Granicus.MediaManager.SDK;
using System.Web.Services.Protocols;

namespace UploadAgenda
{
    public partial class LoginForm : Form
    {
        private MediaManager _mediaManager;
        public LoginForm(MediaManager mediamanager)
        {
            _mediaManager = mediamanager;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string siteID = textBox1.Text;
                //_mediaManager.Connect("http://" + siteID, textBox2.Text, textBox3.Text);
                var md5 = System.Security.Cryptography.MD5.Create();
                string key = BitConverter.ToString(md5.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(siteID))).Replace("-", "").ToLower();
                _mediaManager.ServerConnect("http://" + siteID, key, DateTime.Now.AddDays(2));

                if (_mediaManager.Connected)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox2.Text = "";
                textBox3.Text = "";
                textBox2.Focus();
                this.DialogResult = DialogResult.Abort;
            }
        }
    }
}
