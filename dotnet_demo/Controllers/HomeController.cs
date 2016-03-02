using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dotnet_demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Demo application Description Page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Demo Application Contact Page.";

            return View();
        }
    }
}