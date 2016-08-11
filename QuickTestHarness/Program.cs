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
            // enter your server username/pass here for quick local testing
            string USER = "";
            string PASS = "";

            int i = 1;
            while(true)
            {
                try
                {
                    using(MediaManager mema = new MediaManager("http://mm.lvh.me", USER, PASS))
                    //using (MediaManager mema = new MediaManager("http://dev.dev.granicus.com", USER, PASS))
                    //using (MediaManager mema = new MediaManager("http://green.qa.granicus.com", USER, PASS))
                    {
                        Console.WriteLine("Successfully authed " + i + " times.");
                        i++;

                        // ENTER LOCAL TEST CODE
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Auth Failed - " + e.Message);
                }
               
            }
        }
    }
}
