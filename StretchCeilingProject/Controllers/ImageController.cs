using StretchCeilingProject.BLL;
using StretchCeilingProject.Common;
using StretchCeilingProject.Entity;
using System;
using System.Web.Mvc;

namespace StretchCeilingProject.Controllers
{
    public class ImageController : Controller
    {
        public ImageController(ImageLogic imageLogic)
        {
            this.ImageLogic = imageLogic;
        }

        private ImageLogic ImageLogic { get; }

        public EmptyResult Add(byte[] content)
        {
            Image image = new Image(content);

            this.ImageLogic.Add(image);

            return new EmptyResult();
        }

        public ActionResult Get(Guid? imageId)
        {
            if (!imageId.HasValue ||
                imageId.Value == default(Guid))
            {
                return new FileContentResult(new byte[0], Constant.MIMEType);
            }

            Image content = this.ImageLogic.Get(imageId.Value);

            return new FileContentResult(content.Content, Constant.MIMEType)
            {
                FileDownloadName = imageId.ToString()
            };
        }
    }
}