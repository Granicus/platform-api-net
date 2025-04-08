using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Granicus.MediaManager.SDK;
using System.Web.Services.Protocols;

namespace MeetingSimulator
{
    public partial class LoginForm : Form
    {
        private MediaManager _mediaManager;
        //public MediaManager MediaManagerInstance => _mediaManager;
        public MediaManager MediaManagerInstance
        {
            get { return _mediaManager; }
        }

        public LoginForm(MediaManager mediamanager)
        {
            _mediaManager = mediamanager;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (_mediaManager == null)
                {
                    _mediaManager = new MediaManager();
                }

                _mediaManager.Connect(textBox1.Text, textBox2.Text, textBox3.Text);
                if (_mediaManager.Connected)
                {
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Connected!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
