using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Granicus.MediaManager.SDK;
using SDK_Test.Properties;

namespace SDK_Test
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class Camera
    {
        public static MediaManager mm;
        public int CameraId;

        public Camera()
        {
        }

        #region Helper Methods
        private void CompareCameraProperties(CameraData camera1, CameraData camera2)
        {
            Assert.AreEqual(camera1.Name, camera2.Name);
            Assert.AreEqual(camera1.InternalIP, camera2.InternalIP);
            Assert.AreEqual(camera1.ExternalIP, camera2.ExternalIP);
            Assert.AreEqual(camera1.Identifier, camera2.Identifier);
            Assert.AreEqual(camera1.ControlPort, camera2.ControlPort);
            Assert.AreEqual(camera1.BroadcastPort, camera2.BroadcastPort);
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
            CameraId = mm.CreateCamera(Fixtures.Camera.Initial);
        }

        [TestCleanup()]
        public void After()
        {
            mm.DeleteCamera(CameraId);
        }

        #endregion

        #region Tests 
        [TestMethod]
        public void GetCameras()
        {
            CameraData[] cams = mm.GetCameras();
            CameraData testcamera = null;
            foreach(CameraData cam in cams)
            {
                if (cam.ID == CameraId) testcamera = cam;
            }
            Assert.AreNotEqual(testcamera, null);
            CompareCameraProperties(testcamera, Fixtures.Camera.Initial);
        }

        [TestMethod]
        public void CreateRetrieveUpdateDelete()
        {
            // Tests the create/delete via the before/after methods. Tests Retrieve/update directly.

            // Test Initial Create and Retrieve
            CameraData initialCam = mm.GetCamera(CameraId);
            CompareCameraProperties(initialCam, Fixtures.Camera.Initial);

            // Test Update and Retrieve
            Fixtures.Camera.Update.ID = CameraId; 
            mm.UpdateCamera(Fixtures.Camera.Update);
            CameraData updatedCam = mm.GetCamera(CameraId);
            CompareCameraProperties(updatedCam, Fixtures.Camera.Update);
        }
        #endregion
         
    }
}
