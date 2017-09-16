using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrayerTimes.Models;

namespace PrayerTimes.Controllers
{
    public class HomeController : Controller
    {
        [NonAction]
        public List<Masjid> GetMasjidList()
        {
            return new List<Masjid>
            {
                new Masjid
                {
                    ID = 1,
                    Name = "Rahmat-E-Alam",
                    FajrTime = new DateTime(1,1,1,5,40,0),
                    ZuhrTime = new DateTime(1,1,1,13,15,0),
                    AsrTime = new DateTime(1,1,1,18,0,0),
                    MaghribTime = new DateTime(1,1,1,19,15,0),
                    IshaTime = new DateTime(1,1,1,20,45,0),
                    FirstJumuahTime = new DateTime(1,1,1,13,15,0),
                    SecondJumuahTime = new DateTime(1,1,1,14,30,0),
                },

                new Masjid
                {
                    ID = 2,
                    Name = "Masjid-E-Rahmat",
                    FajrTime = new DateTime(1,1,1,5,20,0),
                    ZuhrTime = new DateTime(1,1,1,13,15,0),
                    AsrTime = new DateTime(1,1,1,18,45,0),
                    MaghribTime = new DateTime(1,1,1,19,15,0),
                    IshaTime = new DateTime(1,1,1,20,30,0),
                    FirstJumuahTime = new DateTime(1,1,1,13,15,0),
                    SecondJumuahTime = new DateTime(1,1,1,14,40,0),
                },

                new Masjid
                {
                    ID = 3,
                    Name = "Jamia Masjid",
                    FajrTime = new DateTime(1,1,1,5,40,0),
                    ZuhrTime = new DateTime(1,1,1,1,30,0),
                    AsrTime = new DateTime(1,1,1,18,15,0),
                    MaghribTime = new DateTime(1,1,1,19,15,0),
                    IshaTime = new DateTime(1,1,1,20,0,0),
                    FirstJumuahTime = new DateTime(1,1,1,13,30,0),
                    SecondJumuahTime = new DateTime(1,1,1,14,30,0),
                },

                new Masjid
                {   
                    ID = 4,
                    Name = "Sharia Board",
                    FajrTime = new DateTime(1,1,1,5,40,0),
                    ZuhrTime = new DateTime(1,1,1,13,30,0),
                    AsrTime = new DateTime(1,1,1,17,45,0),
                    MaghribTime = new DateTime(1,1,1,19,15,0),
                    IshaTime = new DateTime(1,1,1,20,15,0),
                    FirstJumuahTime = new DateTime(1,1,1,13,30,0),
                    SecondJumuahTime = new DateTime(1,1,1,14,30,0),
                },

            };
            }
        public ActionResult Index()
        {
            var masjid = from m in GetMasjidList()
                            orderby m.ID
                            select m;
            return View(masjid);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
