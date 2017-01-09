using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StretchCeilingProject.Controllers
{
    public class ImageController : Controller
    {
        public FileContentResult Get(Guid? id)
        {
            if (id == null ||
                id == default(Guid))
            {
                return new FileContentResult(new byte[0], "image/jpeg");
            }

            byte[] content = new byte[0];

            var result = new FileContentResult(content, "image/jpeg")
            {
                FileDownloadName = id.ToString()
            };

            return result;
        }
    }
}