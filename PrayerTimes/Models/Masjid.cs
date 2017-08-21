using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrayerTimes.Models
{
    public class Masjid
    {
        public string Name { get; set; }

        public int MasjidID { get; set; }

        public PrayerTimings prayerTimings { get; set; }

        public Masjid()
        {

        }
    }

}