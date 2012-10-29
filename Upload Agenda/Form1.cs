using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Granicus.MediaManager.SDK;
using System.Collections;

namespace UploadAgenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createEventButton_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mediamanager = new MediaManager();
            LoginForm login = new LoginForm(mediamanager);
            DialogResult result = login.ShowDialog();
            if (result == DialogResult.OK)
            {
                UpdateListView();
            }
            else
            {
                Application.Exit();
            }
        }

        private void newEventButton_Click(object sender, EventArgs e)
        {
            CreateEvent createEventDialog = new CreateEvent(mediamanager);
            createEventDialog.ShowDialog();
            if (createEventDialog.Success)
            {
                UpdateListView();
                foreach(ListViewItem item in eventListView.Items)
                {
                    if (item.Text == createEventDialog.EventID.ToString())
                    {
                        item.Selected = true;
                    }
                }
            }
        }

        private void UpdateListView()
        {
            EventData[] existingEvents;
            existingEvents = mediamanager.GetEvents();
            eventListView.Items.Clear();
            foreach (EventData eventdata in existingEvents)
            {
                String[] values = { eventdata.ID.ToString(), eventdata.Name, eventdata.StartTime.ToString() };
                ListViewItem item = new ListViewItem(values);
                eventListView.Items.Add(item);
            }
        }

        private void uploadAgendaButton_Click(object sender, EventArgs e)
        {
            DialogResult result = agendaFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                EventData updateEvent = mediamanager.GetEvent(Int32.Parse(eventListView.SelectedItems[0].Text));
                LoadAgendaFile(agendaFileDialog.FileName, updateEvent);
            }
            MessageBox.Show("Agenda uploaded successfully.");
        }

        private void LoadAgendaFile(string filename, EventData updateEvent)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);
            XmlElement root = doc.DocumentElement;

            // update our event with the properties from the XML file
            updateEvent.ForeignID = Int32.Parse(root.SelectSingleNode("ForeignID").InnerText);
            updateEvent.Duration = Int32.Parse(root.SelectSingleNode("Duration").InnerText);
            updateEvent.StartTime = DateTime.Parse(root.SelectSingleNode("StartTime").InnerText);
            updateEvent.Street1 = root.SelectSingleNode("Street1").InnerText;
            updateEvent.Street2 = root.SelectSingleNode("Street2").InnerText;
            updateEvent.City = root.SelectSingleNode("City").InnerText;
            updateEvent.State = root.SelectSingleNode("State").InnerText;
            updateEvent.Zip = root.SelectSingleNode("Zip").InnerText;
            updateEvent.AgendaTitle = root.SelectSingleNode("AgendaTitle").InnerText;
            updateEvent.AgendaPostedDate = DateTime.Parse(root.SelectSingleNode("AgendaPostedDate").InnerText);
            updateEvent.AgendaType = root.SelectSingleNode("AgendaType").InnerText;
            updateEvent.AgendaFile = root.SelectSingleNode("AgendaFile").InnerText;

            // get all the attendees from XML and add them to the event
            XmlNode attendeesNode = root.SelectSingleNode("Attendees");
            updateEvent.Attendees = new AttendeeCollection();
            foreach (XmlNode attendeeNode in attendeesNode.ChildNodes)
            {
                Attendee att = new Attendee();
                att.Name = attendeeNode.SelectSingleNode("Name").InnerText;
                att.Voting = bool.Parse(attendeeNode.SelectSingleNode("Voting").InnerText);
                att.Chair = bool.Parse(attendeeNode.SelectSingleNode("Chair").InnerText);
                updateEvent.Attendees.Add(att);
            }

            // update the event record
            mediamanager.UpdateEvent(updateEvent);

            // get the documentitems node from the XML and process it using our LoadDocumentItems method
            XmlNode documentItemsNode = root.SelectSingleNode("DocumentItems");
            MetaDataDataCollection metaCollection = ParseDocumentItems(documentItemsNode);
            ArrayList al = new ArrayList(metaCollection);
            MetaDataData[] metaArray = (MetaDataData[])al.ToArray(typeof(MetaDataData));
            mediamanager.ImportEventMetaData(updateEvent.ID, metaArray, true, true);
        }

        private MetaDataDataCollection ParseDocumentItems(XmlNode documentItemsNode)
        {
            MetaDataDataCollection metaCollection = new MetaDataDataCollection();

            foreach (XmlNode documentItemNode in documentItemsNode.ChildNodes)
            {
                // process basic MetaDataData properties
                MetaDataData meta = new MetaDataData();
                meta.Name = documentItemNode.SelectSingleNode("Name").InnerText;
                meta.ForeignID = Int32.Parse(documentItemNode.SelectSingleNode("ForeignID").InnerText);
                
                // process payload
                switch (documentItemNode.Name)
                {
                    case "AgendaItem":
                        AgendaItem agendaItem = new AgendaItem();
                        agendaItem.Actions = documentItemNode.SelectSingleNode("Actions").InnerText;
                        agendaItem.Department = documentItemNode.SelectSingleNode("Department").InnerText;
                        meta.Payload = agendaItem;
                        break;
                    case "Note":
                        Note note = new Note();
                        note.NoteText = documentItemNode.SelectSingleNode("NoteText").InnerText;
                        note.EditorsNotes = documentItemNode.SelectSingleNode("EditorsNotes").InnerText;
                        note.Private = bool.Parse(documentItemNode.SelectSingleNode("Private").InnerText);
                        meta.Payload = note;
                        break;
                    case "Document":
                        Document doc = new Document();
                        doc.Description = documentItemNode.SelectSingleNode("Description").InnerText;
                        doc.Location = documentItemNode.SelectSingleNode("Location").InnerText;
                        meta.Payload = doc;
                        break;
                    default:
                        // this isn't payload type we are interested in loading, just skip it
                        continue;
                }
                // recursively process any child nodes
                meta.Children = ParseDocumentItems(documentItemNode.SelectSingleNode("Children"));

                metaCollection.Add(meta);
            }
            return metaCollection;
        }

        private void eventListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eventListView.SelectedItems.Count > 0)
            {
                uploadAgendaButton.Enabled = true;
            }
            else
            {
                uploadAgendaButton.Enabled = false;
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            string eventId = String.Empty;
            if (eventListView.SelectedItems.Count > 0)
            {
                eventId = eventListView.SelectedItems[0].Text;
            }

            UpdateListView();

            foreach (ListViewItem item in eventListView.Items)
            {
                if (item.Text == eventId) item.Selected = true;
            }
        }
    }
}
