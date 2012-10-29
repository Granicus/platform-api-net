using System;
using System.Text;
using System.Collections.Generic;
using System.Collections;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Granicus.MediaManager.SDK;
using SDK_Test.Properties;
using System.Threading;

namespace SDK_Test
{
    /// <summary>
    /// Summary description for Event
    /// </summary>
    [TestClass]
    public class Event
    {
        public int EventId;
        public static MediaManager mm;

        public Event()
        {
            
        }

        #region Helper Methods

        private void CompareEventProperties(EventData event1, EventData event2)
        {
            Assert.AreEqual(event1.Name, event2.Name);
            Assert.AreEqual(event1.AgendaTitle, event2.AgendaTitle);
            //Assert.AreEqual(event1.AgendaPostedDate, event2.AgendaPostedDate);
            Assert.AreEqual(event1.ArchiveStatus, event2.ArchiveStatus);
            Assert.AreEqual(event1.AutoStart, event2.AutoStart);
            Assert.AreEqual(event1.Broadcast, event2.Broadcast);
            Assert.AreEqual(event1.Record, event2.Record);
            Assert.AreEqual(event1.StartTime, event2.StartTime);
            Assert.AreEqual(event1.Street1, event2.Street1);
            Assert.AreEqual(event1.Street2, event2.Street2);
            Assert.AreEqual(event1.City, event2.City);
            Assert.AreEqual(event1.State, event2.State);
            Assert.AreEqual(event1.Zip, event2.Zip);
            Assert.AreEqual(event1.Duration, event2.Duration);
            Assert.AreEqual(event1.CameraID, event2.CameraID);
            Assert.AreEqual(event1.FolderID, event2.FolderID);
            Assert.AreEqual(event1.ForeignID, event2.ForeignID);
        }

        private bool ForeignIDExistsInTree(int ForeignID, MetaDataDataCollection MetaTree)
        {
            if (MetaTree == null) return false;
            foreach (MetaDataData meta in MetaTree)
            {
                if (meta.ForeignID == ForeignID || ForeignIDExistsInTree(ForeignID,meta.Children)) return true;
            }
            return false;
        }

        private void CompareMetaData(MetaDataData meta1, MetaDataData meta2)
        {
            Assert.AreEqual(meta1.Payload.GetType().Name, meta2.Payload.GetType().Name);
            if (meta1.Payload.GetType().Name != "Note")
            {
                // Ignore name field for notes, we know that this is changed by the system (name is note text + editor's note).
                Assert.AreEqual(meta1.Name, meta2.Name);
            }
            Assert.AreEqual(meta1.ForeignID, meta2.ForeignID);
            // TODO: Compare payload
        }

        private void CompareMetaTrees(MetaDataDataCollection tree1, MetaDataDataCollection tree2)
        {
            if (tree1 != null && tree2 != null)
            {
                Assert.AreEqual(tree1.Count, tree2.Count);
                for (int i = 0; i < tree1.Count; i++)
                {
                    CompareMetaData(tree1[i], tree2[i]);

                    CompareMetaTrees(tree1[i].Children, tree2[i].Children);

                }
            }
            else
            {
                //Assert.AreEqual(tree1, tree2);
            }
        }

        private void CompareCommentProperties(Comment comment1, Comment comment2)
        {
            Assert.AreEqual(comment1.CommentText, comment2.CommentText);
            Assert.AreEqual(comment1.FirstName, comment2.FirstName);
            Assert.AreEqual(comment1.LastName, comment2.LastName);
            Assert.AreEqual(comment1.Email, comment2.Email);
            Assert.AreEqual(comment1.Address, comment2.Address);
            Assert.AreEqual(comment1.City, comment2.City);
            Assert.AreEqual(comment1.State, comment2.State);
            Assert.AreEqual(comment1.HasVideo, comment2.HasVideo);
        }

        private void CompareSpeakerProperties(Speaker speaker1, Speaker speaker2)
        {
            Assert.AreEqual(speaker1.FirstName, speaker2.FirstName);
            Assert.AreEqual(speaker1.LastName, speaker2.LastName);
            Assert.AreEqual(speaker1.Email, speaker2.Email);
            Assert.AreEqual(speaker1.Address, speaker2.Address);
            Assert.AreEqual(speaker1.City, speaker2.City);
            Assert.AreEqual(speaker1.State, speaker2.State);
        }

        #endregion

        #region Initialize Tests
        [ClassInitialize()]
        public static void Initialize(TestContext context)
        {
            mm = new MediaManager();
            mm.Connect(Settings.Default.SDKHostName,
                Settings.Default.MMUser,
                Settings.Default.MMPassword);
        }

        [ClassCleanup()]
        public static void Cleanup()
        {
            mm.Disconnect();
        }

        [TestInitialize()]
        public void Before()
        {
            Fixtures.Event.Initial.FolderID = mm.GetFolders()[0].ID;
            Fixtures.Event.Initial.CameraID = mm.GetCameras()[0].ID;
            Fixtures.Event.Update.FolderID = Fixtures.Event.Initial.FolderID;
            Fixtures.Event.Update.CameraID = Fixtures.Event.Initial.CameraID;
            EventId = mm.CreateEvent(Fixtures.Event.Initial);
        }

        [TestCleanup()]
        public void After()
        {
            mm.DeleteEvent(EventId);
        }
        #endregion

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        #region Tests

        [TestMethod]
        public void CreateRetrieveUpdateDelete()
        {
            // Tests the create/delete via the before/after methods. Tests Retrieve/update directly.

            // Test Initial Create and Retrieve
            EventData initialEvent = mm.GetEvent(EventId);
            CompareEventProperties(initialEvent, Fixtures.Event.Initial);

            // Test Update and Retrieve
            Fixtures.Event.Update.ID = EventId; 
            mm.UpdateEvent(Fixtures.Event.Update);
            EventData updatedEvent = mm.GetEvent(EventId);
            CompareEventProperties(updatedEvent,Fixtures.Event.Update);
        }

        [TestMethod] 
        public void GetEvents()
        {
            EventData[] events = mm.GetEvents();
            EventData @event = null;
            foreach(EventData e in events)
            {
                if (e.ID == EventId) @event = e;
            }
            Assert.AreNotEqual(@event, null);
            CompareEventProperties(@event, Fixtures.Event.Initial);
        }

        [TestMethod]
        public void GetEventsByForeignID()
        {
            EventData[] events = mm.GetEventsByForeignID(Fixtures.Event.Initial.ForeignID);
            foreach (EventData @event in events)
            {
                if (@event.ID == EventId)
                {
                    CompareEventProperties(@event, Fixtures.Event.Initial);
                }
            }
        }

        [TestMethod]
        public void GetEventByUID()
        {
            EventData @event = mm.GetEvent(EventId);
            EventData event_by_uid = mm.GetEventByUID(@event.UID);
            CompareEventProperties(@event, event_by_uid);
        }

        [TestMethod]
        public void SetEventAgendaURL()
        {
            mm.SetEventAgendaURL(EventId, "http://www.granicus.com");
            EventData @event = mm.GetEvent(EventId);
            Assert.AreEqual(@event.AgendaFile, "http://www.granicus.com");
            Assert.AreEqual(@event.AgendaType, "linked");
        }

        [TestMethod]
        public void SetEventAgendaURLByUID()
        {
            EventData @event = mm.GetEvent(EventId);
            mm.SetEventAgendaURLByUID(@event.UID, "http://www.granicus.com");
            @event = mm.GetEvent(EventId);
            Assert.AreEqual(@event.AgendaFile, "http://www.granicus.com");
            Assert.AreEqual(@event.AgendaType, "linked");
        }

        [TestMethod]
        public void ImportAndGetEventMetaData()
        {
            KeyMapping[] keys = mm.ImportEventMetaData(EventId, Fixtures.MetaData.MetaTree, true, true);
            foreach (KeyMapping mapping in keys)
            {
                Assert.AreEqual(ForeignIDExistsInTree(mapping.ForeignID, Fixtures.MetaData.MetaTree), true);
            }
            MetaDataData[] result = mm.GetEventMetaData(EventId);
            MetaDataDataCollection compare_meta = new MetaDataDataCollection();
            foreach (MetaDataData row in result)
            {
                compare_meta.Add(row);
            }
            mm.ConvertToMetaTree(ref compare_meta);
            CompareMetaTrees(compare_meta, Fixtures.MetaData.MetaTree);
        }

        [TestMethod]
        public void UploadDownloadDocument()
        {
            KeyMapping[] km = mm.AddEventMetaData(EventId, Fixtures.MetaData.SampleUploadedDocument);
            Document FixtureDocument = ((Document)Fixtures.MetaData.SampleUploadedDocument.Payload);
            Document attachment = mm.FetchAttachment(km[0].GranicusID);
            Assert.AreEqual(attachment.FileContents.Length, FixtureDocument.FileContents.Length);
            Assert.AreEqual(attachment.FileExtension, FixtureDocument.FileExtension);
        }

        [TestMethod]
        public void ImportAndGetEventMetaDataByUID()
        {
            EventData @event = mm.GetEvent(EventId);
            KeyMapping[] keys = mm.ImportEventMetaData(EventId, Fixtures.MetaData.MetaTree, true, true);
            foreach (KeyMapping mapping in keys)
            {
                Assert.AreEqual(ForeignIDExistsInTree(mapping.ForeignID, Fixtures.MetaData.MetaTree), true);
            }
            MetaDataData[] result = mm.GetEventMetaDataByUID(@event.UID);
            MetaDataDataCollection compare_meta = new MetaDataDataCollection();
            foreach (MetaDataData row in result)
            {
                compare_meta.Add(row);
            }
            mm.ConvertToMetaTree(ref compare_meta);
            CompareMetaTrees(compare_meta, Fixtures.MetaData.MetaTree);
        }

        [TestMethod]
        public void TestNextStartDateEdgeCase()
        {
            EventData @event = mm.GetEvent(EventId);
            // set the start time to be in the past by one half of the event's duration, this puts us dead center in our edge case
            @event.StartTime = DateTime.Now - TimeSpan.FromSeconds(@event.Duration / 2);
            mm.UpdateEvent(@event);
            EventData test = mm.GetEvent(EventId);
            Assert.AreEqual(@event.StartTime.Date, test.NextStartDate.Date);
        }

        [TestMethod]
        public void TestCreateEventWithSIRE()
        {
            SIRE.EventData @event = new SIRE.EventData()
            {
                AgendaTitle = "Test",
                Name = "SIRE Test 1",
                StartTime = DateTime.Now + (new TimeSpan(1,0,0,0)),
                Duration = 3600,
                CameraID = Fixtures.Event.Initial.CameraID,
                FolderID = Fixtures.Event.Initial.FolderID,
                ForeignID = (new Random(DateTime.Now.Millisecond).Next())
            };

            SIRE.AlphaCorpConnectorService s = new SIRE.AlphaCorpConnectorService();
            s.CookieContainer = new System.Net.CookieContainer();
            s.login(Settings.Default.MMUser, Settings.Default.MMPassword);
            int event_id = s.createEvent(@event);

            EventData e = mm.GetEvent(event_id);

            Assert.AreEqual(@event.StartTime.ToShortDateString(), e.StartTime.ToShortDateString());
            Assert.AreEqual(@event.Name, e.Name);

            // Now create the same event again, and make sure we don't have a duplicate (we should get back the same event id)
            int event_id_2 = s.createEvent(@event);
            Assert.AreEqual(event_id, event_id_2);

            // Finally create the same event, but with a different date. this should duplicate (check for delta in event id)
            @event.StartTime = @event.StartTime + (new TimeSpan(1, 0, 0, 0));
            event_id_2 = s.createEvent(@event);

            Assert.AreNotEqual(event_id, event_id_2);

            e = mm.GetEvent(event_id_2);
            Assert.AreEqual(@event.StartTime.ToShortDateString(), e.StartTime.ToShortDateString());
        }

        [TestMethod]
        public void TestSetEventAgendaURL()
        {
            mm.SetEventAgendaURL(EventId, "http://www.foobar.com");
            EventData e = mm.GetEvent(EventId);
            Assert.AreEqual(e.AgendaType, "linked");
        }

        [TestMethod]
        public void TestUploadEventAgendaDocument()
        {
            mm.UploadEventAgendaDocument(EventId, (Document)Fixtures.MetaData.SampleUploadedDocument.Payload);
            EventData e = mm.GetEvent(EventId);
            Assert.AreEqual(e.AgendaType, "uploaded");
        }

        #endregion
        
    }
}
