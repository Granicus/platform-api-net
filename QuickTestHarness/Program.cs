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
            UserData user = new UserData()
            {
                Username = "javier4",
                FirstName = "Javier",
                LastName = "Muniz",
                Password = "thisisatest",
                Email = "javier@granicus.com"

            };

            MetaDataData agendaItem = new MetaDataData()
            {
                Name = "Test Item",
                Payload = new AgendaItem()
                {
                    Actions = "Approve",
                    Department = "Department of Better Technology"
                }
            };

            MetaDataData document = new MetaDataData()
            {
                Name = "Test Document",
                Payload = new Document()
                {
                    Location = "http://documentserver.com/mydocument.pdf"
                }
            };

            agendaItem.Children.Add(document);

            MetaDataData[] item_list = new MetaDataData[1];
            item_list[0] = agendaItem;

        }
    }
}
