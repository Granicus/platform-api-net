using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Granicus.MediaManager.SDK;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Granicus.MediaManager.SDK.Tests
{
    [TestClass()]
    public class MediaManagerTests
    {
        [TestMethod()]
        public void UploadClipMinutesDocumentXLTest()
        {
            MediaManager mediamanager = new MediaManager();
            string siteID = "mm.lvh.me";
            var md5 = System.Security.Cryptography.MD5.Create();
            string key = BitConverter.ToString(md5.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(siteID))).Replace("-", "").ToLower();
            mediamanager.ServerConnect("http://" + siteID, key, DateTime.Now.AddDays(2));

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
    }
}
