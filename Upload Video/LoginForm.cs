using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Granicus.MediaManager.SDK;
using System.Web.Services.Protocols;

namespace UploadVideo
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
                _mediaManager.Connect(textBox1.Text, textBox2.Text, textBox3.Text);
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
            }
        }
    }
}
