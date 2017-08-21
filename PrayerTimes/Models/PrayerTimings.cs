using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrayerTimes.Models
{
    public class PrayerTimings
    {
        public string MasjidID { get; set; }
        public string FajrHr { get; set; }
        public string FajrMin { get; set; }

        public string ZhurHr { get; set; }
        public string ZhurMin { get; set; }

        public string AsrHr { get; set; }
        public string AsrMin { get; set; }

        public string MaghribHr { get; set; }
        public string MaghribMin { get; set; }

        public string IshaHr { get; set; }
        public string IshaMin { get; set; }

        public string Jumah1Hr { get; set; }
        public string Jumah1Min { get; set; }

        public string Jumah2Hr { get; set; }
        public string Jumah2Min { get; set; }


        public PrayerTimings()
        {
            Random r = new Random();
            this.FajrHr = r.Next(4, 7).ToString();
            this.ZhurHr = r.Next(1, 2).ToString();
            this.AsrHr = r.Next(4, 7).ToString();
            this.MaghribHr = r.Next(4, 9).ToString();
            this.IshaHr = r.Next(9, 11).ToString();
            this.Jumah1Hr = r.Next(1, 2).ToString();
            this.Jumah2Hr = r.Next(2, 3).ToString();

            this.FajrMin = (r.Next(1, 6)*10).ToString();
            this.ZhurMin = (r.Next(1, 6)*10).ToString();
            this.AsrMin = (r.Next(1, 6)*10).ToString();
            this.MaghribMin = (r.Next(1, 6)*10).ToString();
            this.IshaMin = (r.Next(1, 6)*10).ToString();
            this.Jumah1Min = (r.Next(1, 6) * 10).ToString();
            this.Jumah2Min = (r.Next(1, 6) * 10).ToString();

        }
    }
}