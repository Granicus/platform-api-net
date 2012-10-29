using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Granicus.MediaManager.SDK;

namespace SDK_Test
{
    /// <summary>
    /// A specially constructed sample agenda specifically constructed for testing the APIs
    /// </summary>
    class SampleAgenda
    {
        public MetaDataDataCollection _agenda = new MetaDataDataCollection();

        public SampleAgenda()
        {
            _agenda.Add(new MetaDataData(
                "1. Sample Item I",
                new AgendaItem("Sample Department I", "Approve")
                ));
            _agenda[0].Children = new MetaDataDataCollection();

            _agenda.Add(new MetaDataData(
                "2. Sample Item II",
                new AgendaItem("Sample Department II", "Approve staff action")
                ));
            _agenda[1].Children = new MetaDataDataCollection();

            _agenda.Add(new MetaDataData(
                "3. Sample Item III",
                new AgendaItem("Sample Department III", "Approve budget")
                ));

            _agenda[2].Children = new MetaDataDataCollection();
            _agenda[2].Children.Add(new MetaDataData(
                "a. Sample Sub-Item I",
                new AgendaItem("","")));
            _agenda[2].Children[0].Children = new MetaDataDataCollection();

            _agenda[2].Children.Add(new MetaDataData(
                "b. Sample Sub-Item II",
                new AgendaItem("","")));
            _agenda[2].Children[1].Children = new MetaDataDataCollection();
        }

        public MetaDataData[] Agenda
        {
            get
            {
                ArrayList al = new ArrayList(_agenda);
                return (MetaDataData[])al.ToArray(typeof(MetaDataData));
            }
        }
    }
}
