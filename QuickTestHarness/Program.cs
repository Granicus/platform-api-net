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
            int i = 1;
            while(true)
            {
                try
                {
                    using (MediaManager mm = new MediaManager("http://oregon.granicus.com", "granicus", "secret"))
                    {
                        Console.WriteLine("Successfully authed " + i + " times.");
                        i++;
                    }
                }
                catch
                {
                    Console.WriteLine("Auth Failed.");
                }
               
            }
        }
    }
}
