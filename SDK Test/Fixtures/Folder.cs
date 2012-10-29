using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Granicus.MediaManager.SDK;

namespace SDK_Test.Fixtures
{
    class Folder
    {
        public static FolderData Initial = new FolderData()
        {
            Name = "Platform API .NET Automated Test Folder",
            Description = "API Test Description",
            Type = "Meeting"
        };

        public static FolderData Update = new FolderData()
        {
            Name = "Platform API .NET Automated Test Folder (Updated)",
            Description = "API Test Description (Updated)",
            Type = "Training"
        };
    }
}
