using Mindscape.Raygun4Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RaygunTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //generate error

            decimal d = Convert.ToDecimal("throwerror");
            
            return View();
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