using System;
using System.Text;
using System.Collections.Generic;
using System.Collections;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Granicus.MediaManager.SDK;
using SDK_Test.Properties;

namespace SDK_Test
{
    /// <summary>
    /// Summary description for Event
    /// </summary>
    [TestClass]
    public class Folder
    {
        public static MediaManager mm;
        public int FolderId;

        public Folder()
        {
        }


        #region Helper Methods
        private void CompareFolderProperties(FolderData folder1, FolderData folder2)
        {
            Assert.AreEqual(folder1.Name, folder2.Name);
            Assert.AreEqual(folder1.Description, folder2.Description);
            Assert.AreEqual(folder1.PlayerTemplateID, folder2.PlayerTemplateID);
            Assert.AreEqual(folder1.Type, folder2.Type);
        }
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
            TemplateData[] templates = mm.GetTemplates();
            int PlayerTemplateId = 0;
            foreach(TemplateData template in templates)
            {
                if(template.Type == "Player") PlayerTemplateId = template.ID;
            }

            Fixtures.Folder.Initial.PlayerTemplateID = PlayerTemplateId;
            
            FolderId = mm.CreateFolder(Fixtures.Folder.Initial);
        }

        [TestCleanup()]
        public void After()
        {
            mm.DeleteFolder(FolderId);
        }

        #endregion

        #region Tests
        [TestMethod]
        public void CreateRetrieveUpdateDelete()
        {
            // Tests the create/delete via the before/after methods. Tests Retrieve/update directly.

            // Test Initial Create and Retrieve
            FolderData initialFolder = mm.GetFolder(FolderId);
            CompareFolderProperties(initialFolder, Fixtures.Folder.Initial);

            // Test Update and Retrieve
            Fixtures.Folder.Update.ID = FolderId;
            mm.UpdateFolder(Fixtures.Folder.Update);
            FolderData updatedFolder = mm.GetFolder(FolderId);
            CompareFolderProperties(updatedFolder, Fixtures.Folder.Update);
        }

        #endregion

    }
}
