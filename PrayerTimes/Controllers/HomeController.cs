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
        public ActionResult Index()
        {
            var masjids = new List<Masjid>();

            masjids.Add(new Masjid() { Name = "Rahmat-e-Alam Foundation", MasjidID = 1, prayerTimings = new PrayerTimings() });
            masjids.Add(new Masjid() { Name = "Jamia Masjid", MasjidID = 2, prayerTimings = new PrayerTimings() });
            masjids.Add(new Masjid() { Name = "Noor Masjid", MasjidID = 3, prayerTimings = new PrayerTimings() });
            masjids.Add(new Masjid() { Name = "Makki Masjid", MasjidID = 4, prayerTimings = new PrayerTimings() });
            masjids.Add(new Masjid() { Name = "Rahmat-e-Alam Musallah", MasjidID = 5, prayerTimings = new PrayerTimings() });

            return View(masjids);
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