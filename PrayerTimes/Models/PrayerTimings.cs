using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrayerTimes.Models
{
    public class PrayerTimings
    {
        public int MasjidID { get; set; }
        public DateTime Fajr { get; set; }
       
        public DateTime Zhur { get; set; }
       
        public DateTime Asr { get; set; }
       
        public DateTime Maghrib { get; set; }
       
        public DateTime Isha { get; set; }
       
        public DateTime Jumah1 { get; set; }
    
        public DateTime Jumah2 { get; set; }
       


        public PrayerTimings()
        {
            Random r = new Random();

            Fajr = new DateTime(2001,1,1,r.Next(4,6),(r.Next(1,6))*10,0);
            Zhur = new DateTime(2001, 1, 1, r.Next(1, 2), (r.Next(1, 6)) * 10, 0);
            Asr = new DateTime(2001, 1, 1, r.Next(4, 6), (r.Next(1, 6)) * 10, 0);
            Maghrib = new DateTime(2001, 1, 1, r.Next(5, 8), (r.Next(1, 6)) * 10, 0);
            Isha = new DateTime(2001, 1, 1, r.Next(9, 11), (r.Next(1, 6)) * 10, 0);
            Jumah1 = new DateTime(2001, 1, 1, r.Next(1, 2), (r.Next(1, 6)) * 10, 0);
            Jumah2 = new DateTime(2001, 1, 1, r.Next(3, 4), (r.Next(1, 6)) * 10, 0);


        }
    }
}