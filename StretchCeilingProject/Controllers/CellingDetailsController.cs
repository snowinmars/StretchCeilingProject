using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StretchCeilingProject.Entity;

namespace StretchCeilingProject.Controllers
{
    public class CellingDetailsController : Controller
    {
        public ActionResult Index(Guid id)
        {
            CellingDescription cellingDescription = new CellingDescription
            {
                Description = "asd",
            };

            return View(cellingDescription);
        }
    }
}