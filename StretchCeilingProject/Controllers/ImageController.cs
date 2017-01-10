using StretchCeilingProject.BLL;
using StretchCeilingProject.Common;
using StretchCeilingProject.Entity;
using System;
using System.Diagnostics.Contracts;
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
            Contract.Requires<ArgumentNullException>(content != null, "Image content can not be null");
            Contract.Requires<InvalidOperationException>(content.Length > 0, "Image content must have more that 0 bytes");
            Contract.Requires<InvalidOperationException>(content.Length < Constant.MaxImageLengthInBytes, $"Image content must have less that {Constant.MaxImageLengthInBytes} bytes");

            Image image = new Image(content);

            this.ImageLogic.Add(image);

            return new EmptyResult();
        }

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