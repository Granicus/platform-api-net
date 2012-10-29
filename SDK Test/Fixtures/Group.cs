using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Granicus.MediaManager.SDK;

namespace SDK_Test.Fixtures
{
    class Group
    {
        public static GroupData Initial = new GroupData()
        {
            Name = "Platform API .NET Automated Test Group",
            Description = "Group used for automated testing of the .NET API proxy"
        };

        public static GroupData Update = new GroupData()
        {
            Name = "Platform API .NET Automated Test Group (Updated)",
            Description = "Group used for automated testing of the .NET API proxy (Updated)"
        };
    }
}
