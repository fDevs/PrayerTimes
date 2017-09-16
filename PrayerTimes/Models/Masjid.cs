using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrayerTimes.Models
{
    public class Masjid
    {   public int ID { get; set; }
        public string Name { get; set; }
        [DisplayFormat(DataFormatString = "{0:h:mm tt}")]
        [Display(Name ="Fajr")]
        public DateTime FajrTime { get; set; }
        [DisplayFormat(DataFormatString = "{0:h:mm tt}")]
        public DateTime SunriseTime { get; set; }
        [DisplayFormat(DataFormatString = "{0:h:mm tt}")]
        [Display(Name = "Zuhr")]
        public DateTime ZuhrTime { get; set; }
        [DisplayFormat(DataFormatString = "{0:h:mm tt}")]
        [Display(Name = "Asr")]
        public DateTime AsrTime { get; set; }
        [DisplayFormat(DataFormatString = "{0:h:mm tt}")]
        [Display(Name = "Maghrib")]
        public DateTime MaghribTime { get; set; }
        [DisplayFormat(DataFormatString = "{0:h:mm tt}")]
        [Display(Name = "Isha")]
        public DateTime IshaTime { get; set; }
        [DisplayFormat(DataFormatString = "{0:h:mm tt}")]
        [Display(Name = "First Jumuah")]
        public DateTime FirstJumuahTime { get; set; }
        [DisplayFormat(DataFormatString = "{0:h:mm tt}")]
        [Display(Name = "Second Jumuah")]
        public DateTime SecondJumuahTime { get; set; }

    }
}