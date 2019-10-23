using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Granicus.MediaManager.SDK;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Granicus.MediaManager.SDK.Tests
{
    [TestClass()]
    public class MediaManagerTests
    {

        private string _memaSite = "mm.lvh.me"; // mm.lvh.me
        private string _memaUser = "";
        private string _memaPass = "";
        private MediaManager _mema;

        private string _unitTestFolder = "Unit Test Folder";
        private string _unitTestCamera = "Unit Test Camera";

        [TestInitialize]
        public void Init()
        {
            _mema = new MediaManager(_memaSite, _memaUser, _memaPass);
        }


        [TestMethod()]
        public void UploadEventAgendaAndAddToClip()
        {
            var eventDate = DateTime.Now;
            var eventName = string.Format("Unit Test Event - {0}", eventDate.ToString("g")); // 10/1/2008 5:04 PM
            var testEvent = CreateTestEvent(eventName, eventDate);

            _mema.UploadEventAgendaDocument(testEvent.ID, CreateTestDocument());
            testEvent = _mema.GetEvent(testEvent.ID);

            var testClip = CreateTestClipFromEvent(testEvent);

            testClip.AgendaFile = testEvent.AgendaFile;
            testClip.AgendaPostedDate = testEvent.AgendaPostedDate;
            testClip.AgendaTitle = testEvent.AgendaTitle;
            testClip.AgendaType = testEvent.AgendaType;

            _mema.UpdateClip(testClip);
            testClip = _mema.GetClip(testClip.ID);

            Assert.AreEqual(testEvent.AgendaFile, testClip.AgendaFile);
            Assert.AreEqual(testEvent.AgendaPostedDate, testClip.AgendaPostedDate);
            Assert.AreEqual(testEvent.AgendaTitle, testClip.AgendaTitle);
            Assert.AreEqual(testEvent.AgendaType, testClip.AgendaType);
        }



        [TestMethod()]
        public void UploadClipMinutesDocumentXLTest()
        {
            MediaManager mediamanager = _mema;

            string filePath = System.AppDomain.CurrentDomain.BaseDirectory + @"\test_minutes_small.pdf";

            FolderData[] folders = mediamanager.GetFolders();
            ClipData[] clips = null;

            foreach(FolderData fd in folders)
            {
                clips = mediamanager.GetClips(fd.ID);
                if (clips.Length > 0)
                    break;
            }

            if (clips != null && clips.Length > 0)
            {
                string Name = "Unit-test Uploaded Minutes Document - " + Guid.NewGuid().ToString();
                mediamanager.UploadClipMinutesDocumentXL(clips[0].ID, "unit test attachment", filePath, Name);

                ClipData clip = mediamanager.GetClip(clips[0].ID);

                Assert.AreEqual(clip.MinutesType, "uploaded");

                MinutesDocumentData[] minutesDocs = mediamanager.GetClipMinutesDocuments(clips[0].ID);

                Assert.IsTrue(minutesDocs.Length > 0);

                foreach(MinutesDocumentData mdd in minutesDocs)
                {
                    if (mdd.Default)
                    {
                        Assert.AreEqual(mdd.Name, Name);
                        Assert.AreEqual(mdd.Type, "uploaded");
                        Assert.AreEqual(mdd.Published, true);

                        //cleanup
                        mediamanager.DeleteMinutesDocument(mdd.UID);
                        break;
                    }
                }

            }
        }

        public ClipData CreateTestClipFromEvent(EventData testEvent)
        {
            ClipData ret = null;

            var mediaVault = _mema.GetMediaVault(testEvent.FolderID);
            var path = System.AppDomain.CurrentDomain.BaseDirectory + @"\test_video.mp4";

            using (var source = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(source))
                {
                    var sourceFile = new FileInfo(path);
                    var currentBucket = mediaVault.StartUpload();

                    long currentPosition = 0;
                    var chunksize = 1024 * 1024;
                    var size = sourceFile.Length;

                    while (currentPosition < size)
                    {
                        // send chunk implementation
                        reader.BaseStream.Seek(currentPosition, SeekOrigin.Begin);
                        if (chunksize > (size - currentPosition))
                        {
                            chunksize = (int)(size - currentPosition);
                        }
                        byte[] chunk = new byte[chunksize];
                        reader.Read(chunk, 0, chunksize);
                        mediaVault.SendChunk(currentBucket, currentPosition, chunk);
                        currentPosition += chunksize;
                    }

                    mediaVault.FinishUpload(currentBucket);
                    string extension = sourceFile.Extension.Trim('.');
                    var clipID = mediaVault.RegisterUploadedFile(currentBucket, testEvent.FolderID, testEvent.Name, extension);
                    var clip = _mema.GetClip(clipID);
                    clip.EventUID = testEvent.UID;
                    clip.Date = testEvent.StartTime;
                    clip.StartTime = testEvent.StartTime;
                    _mema.UpdateClip(clip);

                    ret = _mema.GetClip(clipID);
                }
            }

            return ret;
        }

        private EventData CreateTestEvent(string eventName, DateTime eventTime)
        {
            EventData ret = null;

            var folder = GetOrCreateTestFolder();
            var camera = GetOrCreateAnyCamera();
            var newEvent = new EventData();
            newEvent.Name = eventName;
            newEvent.MeetingTime = eventTime;
            newEvent.StartTime = eventTime;
            newEvent.CameraID = camera.ID;
            newEvent.FolderID = folder.ID;

            newEvent.Duration = 2 * 60 * 60;
            newEvent.Record = true;
            newEvent.Broadcast = true;

            var eventID = _mema.CreateEvent(newEvent);
            ret = _mema.GetEvent(eventID);

            return ret;
        }

        private CameraData GetOrCreateAnyCamera()
        {
            CameraData ret = null;

            var cameras = _mema.GetCameras();
            ret = cameras.FirstOrDefault(x => x.Name.ToLower() == _unitTestCamera.ToLower());

            if (ret == null)
            {
                var cameraID = _mema.CreateCamera(new CameraData()
                {
                    Name = _unitTestFolder,
                    Type = "Meeting"
                });
                ret = _mema.GetCamera(cameraID);
            }

            return ret;
        }

        private FolderData GetOrCreateTestFolder()
        {
            FolderData ret = null;

            var folders = _mema.GetFolders();
            ret = folders.FirstOrDefault(x => x.Name.ToLower() == _unitTestFolder.ToLower());

            if (ret == null)
            {
                var folderID = _mema.CreateFolder(new FolderData()
                {
                    Name = _unitTestFolder,
                    Description = _unitTestFolder,
                    Type = "Meeting"
                });
                ret = _mema.GetFolder(folderID);
            }

            return ret;
        }

        private Document CreateTestDocument()
        {
            var path = System.AppDomain.CurrentDomain.BaseDirectory + @"\test_doc.pdf";
            return new Document()
            {
                FileExtension = "pdf",
                FileContents = File.ReadAllBytes(path)
            };
        }



    }
}
