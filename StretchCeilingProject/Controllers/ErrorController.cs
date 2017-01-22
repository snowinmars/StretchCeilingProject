using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StretchCeilingProject.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult Error()
        {
            Response.StatusCode = 400;
            return View();
        }

        public ActionResult Error404()
        {
            Response.StatusCode = 404;
            return View();
        }
    }
}