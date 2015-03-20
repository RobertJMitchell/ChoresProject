using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChoresProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Kitchen()
        {
            ViewBag.Message = "Welcome to the Kitchen Page";

            return View();
        }

        public ActionResult Bedroom()
        {
            ViewBag.Message = "Welcome to the Bedroom (Page)";

            return View();
        }
    }
}