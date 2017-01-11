﻿using System.Collections.Generic;
using System.Web.Mvc;
using StretchCeilingProject.BLL;
using StretchCeilingProject.Entity;
using StretchCeilingProject.Models;

namespace StretchCeilingProject.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(ICellingLogic cellingLogic)
        {
            this.CellingLogic = cellingLogic;
        }

        private ICellingLogic CellingLogic { get; }

        public ActionResult Contacts()
        {
            return View();
        }

        public ActionResult Description()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Price()
        {
            IEnumerable<Celling> goods = this.CellingLogic.GetByFilter();

            return View(goods);
        }
    }
}