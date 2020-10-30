using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NorthwindApp.Models;
using NorthwindApp_DAL;

namespace NorthwindApp.Controllers
{
    public class DatesController : Controller
    {
        // GET: Dates
        public ActionResult About()
        {
            return View();
        }


        public ActionResult SubmitDates(DatesModel dates)
        {

            return Json(new { data = "zorana" }, JsonRequestBehavior.AllowGet);
        }


        public ActionResult GetDates()
        {

            //return View();
            return Json(new { data = "zorana" }, JsonRequestBehavior.AllowGet);
        }


    }
}