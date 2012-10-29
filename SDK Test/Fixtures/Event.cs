using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Granicus.MediaManager.SDK;

namespace SDK_Test.Fixtures
{
    class Event
    {
        public static EventData Initial = new EventData()
        {
            Name = "Platform API .NET Automated Test Event",
            Duration = 3600,
            CommentEnabled = true,
            AutoStart = true,
            Broadcast = true,
            Record = true,
            State = "CA",
            Street1 = "600 Harrison Street",
            Street2 = "Suite 120",
            Zip = "94107",
            City = "San Francisco",
            AgendaPostedDate = DateTime.Today,
            AgendaTitle = "Platform API Test Agenda Title",
            CommentCloseOffset = 3600,
            ArchiveStatus = "Public",
            ForeignID = 30,
            StartTime = DateTime.Today + TimeSpan.FromDays(1.0)
        };

        public static EventData Update = new EventData()
        {
            Name = "Platform API .NET Automated Test Event (Updated)",
            Duration = 10800,
            CommentEnabled = false,
            AutoStart = false,
            Broadcast = false,
            Record = false,
            State = "IL",
            Street1 = "600 Jackson Street",
            Street2 = "Suite 501",
            Zip = "1102",
            City = "Chicago",
            AgendaPostedDate = DateTime.Today - TimeSpan.FromDays(1.0),
            AgendaTitle = "Platform API Test Agenda Title (Updated)",
            CommentCloseOffset = 600,
            ArchiveStatus = "Not Public",
            ForeignID = 20,
            StartTime = DateTime.Today + TimeSpan.FromDays(2.0)
        };
    }
}
