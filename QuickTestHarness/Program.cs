using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Granicus.MediaManager.SDK;

namespace QuickTestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            MediaManager mm = new MediaManager("mm.lvh.me", "administrator", "admin");
            string uid = mm.GetCurrentUserUID();
            UserData[] users = mm.GetUsers();
        }
    }
}
