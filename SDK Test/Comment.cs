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
    public class CommentTests
    {
        public static MediaManager mm;
       
        public CommentTests()
        {
        }


        #region Helper Methods
       
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
            
        }

        [TestCleanup()]
        public void After()
        {
           
        }

        #endregion

        #region Tests
        [TestMethod]
        public void GetCommentsByEventID()
        {
            
        }

        [TestMethod] 
        public void GetCommentsByEventUID()
        {
           
          
        }

        [TestMethod]
        public void GetCommentsByAgendaItemUID()
        {
           
        }
        #endregion

    }
}
