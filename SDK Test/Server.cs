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
    public class Server
    {
        public static MediaManager mm;
        public int ServerId;

        public Server()
        {
        }

        
        #region Helper Methods
        private void CompareServerProperties(ServerData server1, ServerData server2)
        {
            Assert.AreEqual(server1.Name, server2.Name);
            Assert.AreEqual(server1.ControlPort, server2.ControlPort);
            Assert.AreEqual(server1.FirewallCompatibility, server2.FirewallCompatibility);
            Assert.AreEqual(server1.LoadBalancerScore, server2.LoadBalancerScore);
            Assert.AreEqual(server1.Multicast, server2.Multicast);
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

            ServerId = mm.CreateServer(Fixtures.Server.Initial);
        }

        [TestCleanup()]
        public void After()
        {
            mm.DeleteServer(ServerId);
        }
        #endregion


        #region Tests

        [TestMethod]
        public void CreateRetrieveUpdateDelete()
        {
            // Tests the create/delete via the before/after methods. Tests Retrieve/update directly.

            // Test Initial Create and Retrieve
            ServerData initialServer = mm.GetServer(ServerId);
            CompareServerProperties(initialServer, Fixtures.Server.Initial);

            // Test Update and Retrieve
            Fixtures.Server.Update.ID = ServerId;
            mm.UpdateServer(Fixtures.Server.Update);
            ServerData updatedServer = mm.GetServer(ServerId);
            CompareServerProperties(updatedServer, Fixtures.Server.Update);
        }

        [TestMethod]
        public void GetServers()
        {
            ServerData[] servers = mm.GetServers();
            ServerData testserver = null;
            foreach (ServerData server in servers)
            {
                if (server.ID == ServerId) testserver = server;
            }
            Assert.AreNotEqual(testserver, null);
            CompareServerProperties(testserver, Fixtures.Server.Initial);
        }
        
        #endregion

    }
}
