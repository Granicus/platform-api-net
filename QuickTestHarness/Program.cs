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
            MediaManager mm = new MediaManager("enterprise.granicus.com", "granicus", "Gr@nnyBr!ght");
            ClipData[] clips = mm.GetClips(1);
            Console.WriteLine(clips.Length);
            Console.ReadLine();
        }
    }
}
