using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Granicus.MediaManager.SDK;
using SDK_Test.Properties;
using System.IO;

namespace SDK_Test.Fixtures
{
    class MetaData
    {
        public static string SampleDocumentPath = "..\\..\\..\\SDK Test\\bin\\Debug\\sample.pdf";
        // Static constructor initializes the collections in the fixtures
        static MetaData()
        {
            SampleAgendaWithChildren.Children.Add(SampleAgenda);
            SampleAgendaWithChildren.Children.Add(SamplePrivateNote);
            SampleAgendaWithChildren.Children.Add(SamplePublicNote);
            SampleAgendaWithChildren.Children.Add(SampleLinkedDocument);
            SampleAgendaWithChildren.Children.Add(SampleUploadedDocument);
            MetaTree.Add(SampleAgendaWithChildren);
        }

        public static MetaDataDataCollection MetaTree = new MetaDataDataCollection();

        public static MetaDataData SampleAgendaWithChildren = new MetaDataData()
        {
            Name = "Automated Test Agenda Item w/Children",
            ForeignID = 19,
            Payload = new AgendaItem()
            {
                Actions = "Approve Item",
                Department = "Test Department"
            },
            Children = new MetaDataDataCollection()
        };

        public static MetaDataData SampleAgenda = new MetaDataData()
        {
            Name = "Automated Test Agenda Item",
            ForeignID = 20,
            Payload = new AgendaItem()
            {
                Actions = "Approve Item",
                Department = "Test Department"
            }
        };

        public static MetaDataData SamplePublicNote = new MetaDataData()
        {
            Name = "Automated Test Public Note",
            ForeignID = 21,
            Payload = new Note()
            {
                NoteText = "Automated Test Sample Public Note",
                EditorsNotes = "Automated Test Sample Editor's Note",
                Private = false
            }
        };

        public static MetaDataData SamplePrivateNote = new MetaDataData()
        {
            Name = "Automated Test Private Note",
            ForeignID = 21,
            Payload = new Note()
            {
                NoteText = "Automated Test Sample Private Note",
                EditorsNotes = "Automated Test Sample Editor's Note",
                Private = true
            }
        };

        public static MetaDataData SampleUploadedDocument = new MetaDataData()
        {
            Name = "Automated Test Uploaded Document",
            ForeignID = 22,
            Payload = new Document()
            {
                Description = "Test for uploaded documents",
                FileContents = File.ReadAllBytes(SampleDocumentPath),
                FileExtension = (new FileInfo(SampleDocumentPath)).Extension.Substring(1)
            }
        };

        public static MetaDataData SampleLinkedDocument = new MetaDataData()
        {
            Name = "Automated Test Linked Document",
            ForeignID = 22,
            Payload = new Document()
            {
                Description = "Test for Linked documents",
                Location = "http://www.granicus.com"
            }
        };
    }
}
