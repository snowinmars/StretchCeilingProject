using StretchCeilingProject.BLL;
using StretchCeilingProject.Common;
using StretchCeilingProject.Entity;
using System;
using System.Web.Mvc;

namespace StretchCeilingProject.Controllers
{
    public class ImageController : Controller
    {
        public ImageController(ImageLogic imageProvider)
        {
            this.ImageProvider = imageProvider;
        }

        private ImageLogic ImageProvider { get; }

        public EmptyResult Add(byte[] content)
        {
            Image image = new Image(content);

            this.ImageProvider.Add(image);

            return new EmptyResult();
        }

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
    }
}