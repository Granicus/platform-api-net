using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Granicus.MediaManager.SDK;
using System.Xml;
using System.Collections;

namespace DownloadMinutes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node.Level == 0)
            {
                // this is a folder, we can't get minutes for this
                saveButton.Enabled = false;
            }
            else
            {
                // we have a clip, allow downloading
                saveButton.Enabled = true;
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            saveFileDialog1.FileName = node.Text + ".xml";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XmlTextWriter writer = new XmlTextWriter(saveFileDialog1.FileName, System.Text.Encoding.UTF8);
                
                ClipData clip = mediamanager.GetClip(Int32.Parse(node.Name));
                MetaDataData[] meta = mediamanager.GetClipMetaData(Int32.Parse(node.Name));
                mediamanager.ConvertToMetaTree(ref meta);

                // write the XML document
                writer.WriteStartDocument();
                writer.WriteStartElement("SimpleMeetingDocument");

                // write the clip properties
                ReflectionWriter(writer, clip);

                // write the items
                writer.WriteStartElement("DocumentItems");
                WriteXmlFromMetaData(writer, meta);
                writer.WriteEndElement();

                // finish the document
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mediamanager = new MediaManager();
            LoginForm login = new LoginForm(mediamanager);
            DialogResult result = login.ShowDialog();
            if (result == DialogResult.OK)
            {
                FolderData[] folders = mediamanager.GetFolders();
                foreach (FolderData folder in folders)
                {
                    TreeNode foldernode = treeView1.Nodes.Add(folder.Name);
                    ClipData[] clips = mediamanager.GetClips(folder.ID);
                    foreach (ClipData clip in clips)
                    {
                        foldernode.Nodes.Add(clip.ID.ToString(), clip.Name + " - " + clip.ID);
                    }
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void WriteXmlFromMetaData(XmlTextWriter writer, MetaDataData[] meta_array)
        {
            foreach (MetaDataData meta in meta_array)
            {
                // start writing metadata
                writer.WriteStartElement(meta.Payload.GetType().Name);
                // write ID 
                writer.WriteStartElement("ID");
                writer.WriteValue(meta.ID);
                writer.WriteEndElement();

                // write UID 
                writer.WriteStartElement("UID");
                writer.WriteValue(meta.UID);
                writer.WriteEndElement();

                if (meta.TimeStamp >= 0)
                {
                    // write timestamp
                    writer.WriteStartElement("TimeStamp");
                    writer.WriteValue(meta.TimeStamp);
                    writer.WriteEndElement();
                }

                // Write name
                writer.WriteStartElement("Name");
                writer.WriteString(meta.Name);
                writer.WriteEndElement();

                // write foreignid
                writer.WriteStartElement("ForeignID");
                writer.WriteValue(meta.ForeignID);
                writer.WriteEndElement();

                // write any object-specific data
                ReflectionWriter(writer, meta.Payload);

                // write metadata children
                writer.WriteStartElement("Children");
                WriteXmlFromMetaData(writer, meta.Children);
                writer.WriteEndElement();

                // finish writing metadata
                writer.WriteEndElement();
            }
        }

        private void WriteXmlFromMetaData(XmlTextWriter writer, MetaDataDataCollection meta_collection)
        {
            ArrayList al = new ArrayList(meta_collection);
            MetaDataData[] meta = (MetaDataData[])al.ToArray(typeof(MetaDataData));
            WriteXmlFromMetaData(writer, meta);
        }

        private void ReflectionWriter(XmlTextWriter writer, object payload)
        {
            IList list = payload as IList;
            if (list != null)
            {
                foreach (object entry in list)
                {
                    writer.WriteStartElement(entry.GetType().Name);
                    if (entry.GetType().IsPrimitive || entry.GetType().Namespace == "System")
                    {
                        writer.WriteValue(entry);
                    } else {
                        ReflectionWriter(writer, entry);
                    }
                    writer.WriteEndElement();
                }
            }
            else
            {
                System.Reflection.PropertyInfo[] props = payload.GetType().GetProperties();
                foreach (System.Reflection.PropertyInfo property in props)
                {
                    if (property.PropertyType.IsPrimitive || property.PropertyType.Namespace == "System") 
                    {
                        // primitive and system types can be output directly
                        writer.WriteStartElement(property.Name);
                        writer.WriteValue(property.GetValue(payload, null));
                        writer.WriteEndElement();
                    }
                    else
                    {
                        // other types should be reflected recursively, adding the property name element if we are dealing with a list
                        list = property.GetValue(payload, null) as IList;
                        if (list != null) writer.WriteStartElement(property.Name);
                        ReflectionWriter(writer, property.GetValue(payload, null));
                        if (list != null) writer.WriteEndElement();
                    }
                }
            }
        }
    }
}
