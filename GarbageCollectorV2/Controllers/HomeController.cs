﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GarbageCollectorV2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Home()
        {
            bool role = User.IsInRole("Customer");
            if (role)
            {
                return RedirectToAction("CustomerHome", "Customers");

            }
           
            role = User.IsInRole("Employer");
            if (role)
            {
                return RedirectToAction("Home", "Employers");
            }

            return RedirectToAction("Index", "Home");

        }


    }
}
