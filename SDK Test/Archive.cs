using System;
using System.Text;
using System.Collections.Generic;
using System.Collections;
using System.IO;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Granicus.MediaManager.SDK;
using SDK_Test.Properties;
using System.Threading;

namespace SDK_Test
{
    /// <summary>
    /// Summary description for Clip
    /// </summary>
    [TestClass]
    public class Archive
    {
        public static MediaManager mm;
        public int ClipId;
        public int FolderId;

        public Archive()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        #region Helper Methods

        public int UploadTestClip(string FilePath, int FolderId)
        {
            MediaVault mv = mm.GetMediaVault(FolderId);

            FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            FileInfo fi = new FileInfo(FilePath);
            BinaryReader br = new BinaryReader(fs);

            long length = fi.Length;
            string bucket = mv.StartUpload();
            long cursor = 0;
            long chunksize = 32768;
            while (cursor < length)
            {
                br.BaseStream.Seek(cursor, SeekOrigin.Begin);
                if (chunksize > (length - cursor))
                {
                    chunksize = length - cursor;
                }
                byte[] buffer = new byte[chunksize];
                br.Read(buffer, 0, (int)chunksize);
                bool unsent = true;
                int tries = 0;
                while (unsent && tries < 3)
                {
                    try
                    {
                        mv.SendChunk(bucket, cursor, buffer);
                        unsent = false;
                        cursor += chunksize;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Failed chunk send attempt at position {0}: {1}", cursor, ex.ToString());
                        tries++;
                    }
                }
            }
            mv.FinishUpload(bucket);
            return mv.RegisterUploadedFile(bucket, FolderId, fi.Name, fi.Extension);
        }

        private void CompareArchiveProperties(ClipData clip1, ClipData clip2)
        {
            Assert.AreEqual(clip1.Name, clip2.Name);
            Assert.AreEqual(clip1.Date, clip2.Date);
            Assert.AreEqual(clip1.Description, clip2.Description);
            Assert.AreEqual(clip1.FileName, clip2.FileName);
            Assert.AreEqual(clip1.Keywords, clip2.Keywords);
            Assert.AreEqual(clip1.AgendaTitle, clip2.AgendaTitle);
            Assert.AreEqual(clip1.AgendaPostedDate, clip2.AgendaPostedDate);
            Assert.AreEqual(clip1.Status, clip2.Status);
            Assert.AreEqual(clip1.StartTime, clip2.StartTime);
            Assert.AreEqual(clip1.Street1, clip2.Street1);
            Assert.AreEqual(clip1.Street2, clip2.Street2);
            Assert.AreEqual(clip1.City, clip2.City);
            Assert.AreEqual(clip1.State, clip2.State);
            Assert.AreEqual(clip1.Zip, clip2.Zip);
            Assert.AreEqual(clip1.Duration, clip2.Duration);
            Assert.AreEqual(clip1.CameraID, clip2.CameraID);
            Assert.AreEqual(clip1.FolderID, clip2.FolderID);
            Assert.AreEqual(clip1.ForeignID, clip2.ForeignID);
        }

        private bool ForeignIDExistsInTree(int ForeignID, MetaDataDataCollection MetaTree)
        {
            if (MetaTree == null) return false;
            foreach (MetaDataData meta in MetaTree)
            {
                if (meta.ForeignID == ForeignID || ForeignIDExistsInTree(ForeignID, meta.Children)) return true;
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

        #region Test Initialization
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
            FolderId = mm.GetFolders()[0].ID;
            ClipId = UploadTestClip(Fixtures.Archive.SampleVideoPath, FolderId);
        }

        [TestCleanup()]
        public void After()
        {
            mm.DeleteClip(ClipId);
        }

        #endregion

        #region Tests

        [TestMethod]
        public void CreateRetrieveUpdateDelete()
        {
            FileInfo fi = new FileInfo(Fixtures.Archive.SampleVideoPath);
            ClipData testclip = mm.GetClip(ClipId);
            Assert.AreEqual(testclip.Name, fi.Name);

            testclip.Name = "Platform API Automated Test";
            // update clip to desired values
            mm.UpdateClip(testclip);

            // test get clip
            ClipData compareClip = mm.GetClip(ClipId);
            CompareArchiveProperties(testclip, compareClip);
        }

        [TestMethod]
        public void GetClipByUID()
        {
            ClipData clip = mm.GetClip(ClipId);
            ClipData clip_by_uid = mm.GetClipByUID(clip.UID);
            CompareArchiveProperties(clip, clip_by_uid);
        }

        [TestMethod]
        public void GetClips()
        {
            ClipData clip = mm.GetClip(ClipId);
            ClipData[] clips = mm.GetClips(FolderId);
            ClipData testclip = null;
            foreach (ClipData c in clips)
            {
                if (c.ID == clip.ID) testclip = c;
            }
            Assert.AreNotEqual(testclip,null);
            CompareArchiveProperties(testclip, clip);
        }

        [TestMethod]
        [ExpectedException(typeof(System.Web.Services.Protocols.SoapException))]
        public void GetInvalidClips()
        {
            ClipData clip = mm.GetClip(0);
        }

        [TestMethod]
        public void GetClipsByForeignID()
        {
            // First we need to update the clip to have our foreignid
            ClipData init_clip = mm.GetClip(ClipId);
            init_clip.ForeignID = 3303345;
            mm.UpdateClip(init_clip);

            // Now see if we can query it out
            ClipData[] clips = mm.GetClipsByForeignID(init_clip.ForeignID);
            foreach (ClipData clip in clips)
            {
                CompareArchiveProperties(init_clip, clip);
            }
        }

        [TestMethod]
        public void ImportAndGetClipMetaData()
        {
            KeyMapping[] keys = mm.ImportClipMetaData(ClipId, Fixtures.MetaData.MetaTree, true, true);
            foreach (KeyMapping mapping in keys)
            {
                Assert.AreEqual(ForeignIDExistsInTree(mapping.ForeignID, Fixtures.MetaData.MetaTree), true);
            }
            MetaDataData[] result = mm.GetClipMetaData(ClipId);
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
            KeyMapping[] km = mm.AddClipMetaData(ClipId, Fixtures.MetaData.SampleUploadedDocument);
            Document FixtureDocument = ((Document)Fixtures.MetaData.SampleUploadedDocument.Payload);
            Document attachment = mm.FetchAttachment(km[0].GranicusID);
            Assert.AreEqual(attachment.FileContents.Length, FixtureDocument.FileContents.Length);
            Assert.AreEqual(attachment.FileExtension, FixtureDocument.FileExtension);
        }

        [TestMethod]
        public void ImportAndGetClipMetaDataByUID()
        {
            ClipData clip = mm.GetClip(ClipId);
            KeyMapping[] keys = mm.ImportClipMetaData(ClipId, Fixtures.MetaData.MetaTree, true, true);
            foreach (KeyMapping mapping in keys)
            {
                Assert.AreEqual(ForeignIDExistsInTree(mapping.ForeignID, Fixtures.MetaData.MetaTree), true);
            }
            MetaDataData[] result = mm.GetClipMetaDataByUID(clip.UID);
            MetaDataDataCollection compare_meta = new MetaDataDataCollection();
            foreach (MetaDataData row in result)
            {
                compare_meta.Add(row);
            }
            mm.ConvertToMetaTree(ref compare_meta);
            CompareMetaTrees(compare_meta, Fixtures.MetaData.MetaTree);
        }

        [TestMethod]
        public void SetClipMinutesURLWithName()
        {
            mm.SetClipMinutesURLWithName(ClipId, "http://www.foobar.com", "Granicus Website");
            ClipData clip = mm.GetClip(ClipId);
            Assert.AreEqual(clip.MinutesFile, "http://www.foobar.com");
            Assert.AreEqual(clip.MinutesType, "linked");
        }

        [TestMethod]
        public void UploadClipMinutesDocument()
        {
            mm.UploadClipMinutesDocument(ClipId, (Document) Fixtures.MetaData.SampleUploadedDocument.Payload, "Test Upload");
            ClipData clip = mm.GetClip(ClipId);
            Assert.AreEqual(clip.MinutesType, "uploaded");
        }

        [TestMethod]
        public void GetClipMinutesDocuments()
        {
            mm.UploadClipMinutesDocument(ClipId, (Document)Fixtures.MetaData.SampleUploadedDocument.Payload, "Test Upload");
            MinutesDocumentData[] docs = mm.GetClipMinutesDocuments(ClipId);
            Assert.AreEqual(1, docs.Length);
            Assert.AreEqual("Test Upload", docs[0].Name);
            Assert.AreEqual(true, docs[0].Published);
            Assert.AreEqual(true, docs[0].Default);
        }

        [TestMethod]
        public void DeleteClipMinutesDocument()
        {
            mm.UploadClipMinutesDocument(ClipId, (Document)Fixtures.MetaData.SampleUploadedDocument.Payload, "Test Upload");
            MinutesDocumentData[] docs = mm.GetClipMinutesDocuments(ClipId);
            Assert.AreEqual(1, docs.Length);
            mm.DeleteMinutesDocument(docs[0].UID);
            docs = mm.GetClipMinutesDocuments(ClipId);
            Assert.AreEqual(null, docs);
        }

        #endregion

    }
}
