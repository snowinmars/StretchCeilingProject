using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StretchCeilingProject.BLL;
using StretchCeilingProject.Common;
using StretchCeilingProject.Entity;

namespace StretchCeilingProject.Controllers
{
    public class ImageController : Controller
    {
        public ImageController(ImageLogic imageProvider)
        {
            this.ImageProvider = imageProvider;
        }

        private ImageLogic ImageProvider { get; }

        public ActionResult Get(Guid? imageId)
        {
            if (imageId == null ||
                imageId == default(Guid))
            {
                return new FileContentResult(new byte[0], Constant.MIMEType);
            }

            byte[] content = new byte[0];

            var result = new FileContentResult(content, Constant.MIMEType)
            {
                FileDownloadName = imageId.ToString()
            };

            return result;
        }

        public EmptyResult Add(byte[] content)
        {
            Image image = new Image(content);

            this.ImageProvider.Add(image);

            return new EmptyResult();
        }
    }
}