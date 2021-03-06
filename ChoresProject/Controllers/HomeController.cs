﻿using ChoresProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChoresProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() // Main Chores Area
        {
            
            return View();
        }

        public ActionResult Kitchen() // Kitchen Chores Area
        {
            ViewBag.Message = "Welcome to the Kitchen Page";

            ChoreViewModel viewModel = new ChoreViewModel();
            List<Chores> kList = new List<Chores>()
            {
               new Chores(){ID=0, Chore="Kitchen Clean Table", isCompleted=false, ChoreAssigned=DateTime.Now.AddDays(-7)},
               new Chores(){ID=1, Chore="Kitchen Wash Dishes", isCompleted=false, ChoreAssigned=DateTime.Now.AddDays(-6)},
               new Chores(){ID=2, Chore="Kitchen Sweep Floor", isCompleted=false, ChoreAssigned=DateTime.Now.AddDays(-3)},
               new Chores(){ID=3, Chore="Kitchen Clean Stove", isCompleted=false, ChoreAssigned=DateTime.Now.AddDays(-2)},
               new Chores(){ID=4, Chore="Kitchen Clean Refridgerator", isCompleted=false, ChoreAssigned=DateTime.Now.AddDays(-4)},
               new Chores(){ID=5, Chore="Bedroom Make Bed", isCompleted=true, ChoreAssigned=DateTime.Now.AddDays(-10)},
               new Chores(){ID=6, Chore="Bedroom Clean Floor", isCompleted=true, ChoreAssigned=DateTime.Now.AddDays(-8)},
               new Chores(){ID=7, Chore="Bedroom Unmount Sex Swing", isCompleted=true, ChoreAssigned=DateTime.Now.AddDays(-9)},
               new Chores(){ID=8, Chore="Bedroom Repair Headboard", isCompleted=true, ChoreAssigned=DateTime.Now.AddDays(-8)},
               new Chores(){ID=9, Chore="Bedroom Bury Dead Body", isCompleted=true, ChoreAssigned=DateTime.Now.AddDays(-10)},
            };

            viewModel.MyChores = kList;
            return View(viewModel);
        }

       
    }
}