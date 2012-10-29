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
    public class Group
    {
        public static MediaManager mm;
        public int GroupId;
        public Group()
        {
            
        }

        #region Helper Methods
        private void CompareGroupProperties(GroupData group1, GroupData group2)
        {
            Assert.AreEqual(group1.Name, group2.Name);
            Assert.AreEqual(group1.Description, group2.Description);
        }
        #endregion
        /*
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
            
            GroupId = mm.CreateGroup(Fixtures.Group.Initial);
        }

        [TestCleanup()]
        public void After()
        {
            mm.DeleteGroup(GroupId);
        }
        #endregion

        #region Tests
        [TestMethod]
        public void CreateRetrieveUpdateDelete()
        {
            // Tests the create/delete via the before/after methods. Tests Retrieve/update directly.

            // Test Initial Create and Retrieve
            GroupData initialGroup = mm.GetGroup(GroupId);
            CompareGroupProperties(initialGroup, Fixtures.Group.Initial);

            // Test Update and Retrieve
            Fixtures.Group.Update.ID = GroupId;
            mm.UpdateGroup(Fixtures.Group.Update);
            GroupData updatedGroup = mm.GetGroup(GroupId);
            CompareGroupProperties(updatedGroup, Fixtures.Group.Update);
        }

        [TestMethod]
        public void GetGroups()
        {
            GroupData[] groups = mm.GetGroups();
            GroupData testgroup = null;
            foreach (GroupData group in groups)
            {
                if (group.ID == GroupId) testgroup = group;
            }
            Assert.AreNotEqual(testgroup, null);
            CompareGroupProperties(testgroup, Fixtures.Group.Initial);
        }

        #endregion
         */

    }
}
