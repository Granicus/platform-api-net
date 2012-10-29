using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Granicus.MediaManager.SDK;
using SDK_Test.Properties;

namespace SDK_Test.Fixtures
{
    class Camera
    {
        public static CameraData Initial = new CameraData()
        {
            Type = "Meeting",
            Name = "Platform API .NET Automated Test Event",
            ControlPort = 85,
            BroadcastPort = 8080,
            InternalIP = "10.100.0.229",
            ExternalIP = "207.7.154.141",
            Identifier = "SDKtestcamera1"
        };

        public static CameraData Update = new CameraData()
        {
            Type = "Traffic",
            Name = "Platform API .NET Automated Test Event (Updated)",
            ControlPort = 80,
            BroadcastPort = 8085,
            InternalIP = "192.168.1.1",
            ExternalIP = "10.0.0.1",
            Identifier = "updatedCamera"
        };
    }
}
