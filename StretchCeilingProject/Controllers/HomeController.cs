using StretchCeilingProject.BLL;
using StretchCeilingProject.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

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

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Price()
        {
            IEnumerable<IGrouping<CellingCategory, Celling>> goods = this.CellingLogic.GetGroupedByCategory();

            return View(goods);
        }

        public ActionResult Reviews()
        {
            return View();
        }
    }
}