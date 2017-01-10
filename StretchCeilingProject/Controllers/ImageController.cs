using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StretchCeilingProject.Controllers
{
    public class ImageController : Controller
    {
        public ActionResult Get(Guid? imageId)
        {
            if (imageId == null ||
                imageId == default(Guid))
            {
                return new FileContentResult(new byte[0], "image/png");
            }

            byte[] content = new byte[0];

            var result = new FileContentResult(content, "image/png")
            {
                FileDownloadName = imageId.ToString()
            };

            return result;
        }
    }
}