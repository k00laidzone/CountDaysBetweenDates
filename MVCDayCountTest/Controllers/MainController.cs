using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDayCountTest.Models;

namespace MVCDayCountTest.Controllers
{
    public class MainController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string StartDate, string EndDate)
        {

            var GetCountedDays = new DaysBetweenDatesCounter();
            var Days = GetCountedDays.GetDays(StartDate, EndDate);
            
            NumberOfDays FinalDaysCounted = new NumberOfDays();
            FinalDaysCounted.FinalCount = Days;

            return View(FinalDaysCounted);
        }

    }
}
