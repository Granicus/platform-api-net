using Granicus.MediaManager.SDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MeetingSimulator
{
    public partial class StartUpSelection : Form
    {
        public StartUpSelection()
        {
            InitializeComponent();
            this.Load += new EventHandler(StartUpSelection_Load);
        }
        private void StartUpSelection_Load(object sender, EventArgs e)
        {
            cboAvailableForms.Items.Add("LoginForm");
            cboAvailableForms.Items.Add("Form1");
            cboAvailableForms.Items.Add("Event");
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            string selectedForm = cboAvailableForms.SelectedItem.ToString();
            Form formToLaunch = null;

            MediaManager mediaManager = new MediaManager();

            switch (selectedForm)
            {
                case "LoginForm":
                    formToLaunch = new LoginForm(mediaManager);
                    break;
                case "Form1":
                    formToLaunch = new Form1();
                    break;
                case "Event":
                    formToLaunch = new Event();
                    break;
                default:
                    MessageBox.Show("Please select a valid form.");
                    return;
            }

            if (formToLaunch != null)
            {
                formToLaunch.BringToFront();
                formToLaunch.StartPosition = FormStartPosition.CenterScreen;    
                formToLaunch.Show();
                // keep current form open
            }
        }
    }
}
