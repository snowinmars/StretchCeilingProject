using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StretchCeilingProject.BLL;
using StretchCeilingProject.Entity;

namespace StretchCeilingProject.Controllers
{
    public class CellingDetailsController : Controller
    {
        public CellingDetailsController(ICellingLogic cellingLogic)
        {
            this.CellingLogic = cellingLogic;
        }

        private ICellingLogic CellingLogic { get; }

        public ActionResult Index(Guid id)
        {
            Celling c = this.CellingLogic.Get(id);
            CellingDescription cellingDescription = this.CellingLogic.GetDescription(id);

            return View(new KeyValuePair<string, CellingDescription>(c.Title, cellingDescription));
        }
    }
}