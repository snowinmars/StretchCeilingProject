using StretchCeilingProject.BLL;
using StretchCeilingProject.Common;
using StretchCeilingProject.Entity;
using System;
using System.Diagnostics.Contracts;
using System.IO;
using System.Web;
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

        [HttpPost]
        public EmptyResult Add(HttpPostedFileBase file)
        {
            Contract.Requires<ArgumentNullException>(file != null, "Image content can not be null");
            Contract.Requires<InvalidOperationException>(file.ContentLength > 0, "Image content is too small");

            byte[] array;

            using (MemoryStream ms = new MemoryStream())
            {
                file.InputStream.CopyTo(ms);
                array = ms.GetBuffer();
            }
            
            Image image = new Image(array);

            this.ImageLogic.Add(image);

            return new EmptyResult();
        }

        [HttpGet]
        public ActionResult Get(Guid? imageId)
        {
            Contract.Requires<ArgumentNullException>(imageId.HasValue, "Image id can not be null");
            Contract.Requires<InvalidOperationException>(imageId.Value != default(Guid), "Image id can not be default");

            Image content = this.ImageLogic.Get(imageId.Value);

            return new FileContentResult(content.Content, Constant.MIMEType)
            {
                FileDownloadName = imageId.ToString()
            };
        }
    }
}