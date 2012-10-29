using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Granicus.MediaManager.SDK;
namespace SDK_Test.Fixtures
{
    class Server
    {
        public static ServerData Initial = new ServerData()
        {
            Name = "Platform API .NET Automated Test Server",
            ControlPort = 85,
            FirewallCompatibility = true,
            LoadBalancerScore = 10,
            Multicast = true
        };

        public static ServerData Update = new ServerData()
        {
            Name = "Platform API .NET Automated Test Server (Updated)",
            ControlPort = 443,
            FirewallCompatibility = false,
            LoadBalancerScore = 20,
            Multicast = false
        };
    }
}
