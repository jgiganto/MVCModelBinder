﻿using MVCModelBinder.Binders;
using MVCModelBinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCModelBinder.Controllers
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
        public void PostData([ModelBinder(typeof(PersonaModelBinder))] Persona person)
        {

        }

        public ActionResult PersonaModelBinder()
        {
            return View();
        }

    }
}