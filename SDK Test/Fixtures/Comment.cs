using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Granicus.MediaManager.SDK;
using SDK_Test.Properties;

namespace SDK_Test.Fixtures
{
    class Comment
    {
        public static Granicus.MediaManager.SDK.Comment Support = new Granicus.MediaManager.SDK.Comment()
        {
            CommentText = "This is a test comment in support of the eComment Test Item.",
            FirstName = "Javier",
            LastName = "Muniz",
            Email = "javier@granicus.com",
            Address = "600 Harrison St. Suite 120",
            City = "San Francisco",
            State = "CA",
            Zip = "94107",
            Position = "Support"
        };

        public static Granicus.MediaManager.SDK.Comment Oppose = new Granicus.MediaManager.SDK.Comment()
        {
            CommentText = "This is a test comment in opposition of the eComment Test Item.",
            FirstName = "Javier",
            LastName = "Muniz",
            Email = "javier@granicus.com",
            Address = "600 Harrison St. Suite 120",
            City = "San Francisco",
            State = "CA",
            Zip = "94107",
            Position = "Oppose"
        };
    }
}
