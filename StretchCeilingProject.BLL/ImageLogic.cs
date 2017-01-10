using StretchCeilingProject.Common;
using StretchCeilingProject.DAL;
using StretchCeilingProject.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace StretchCeilingProject.BLL
{
    public class ImageLogic : ILogic<Image>
    {
        public ImageLogic(ImageDao imageDao)
        {
            this.ImageDao = imageDao;
        }

        private ImageDao ImageDao { get; }

        public void Add(Image item)
        {
            Contract.Requires<ArgumentNullException>(item != null, "Image can not be null");
            Contract.Requires<InvalidOperationException>(item.Content.Length > 0, "Image content is too small");

            if (this.IsValidImage(item))
            {
                this.ImageDao.Add(item);
            }
            else
            {
                throw new InvalidOperationException($"Can't add item with id {item.Id}: logic layer validation failed");
            }
        }

        private bool IsValidImage(Image item)
        {
            if (item.Content.Length > Constant.MaxImageLengthInBytes ||
                    string.IsNullOrWhiteSpace(item.MIMEType) ||
                    item.Id == default(Guid))
            {
                return false;
            }

            return true;
        }

        public Image Get(Guid id)
        {
            return this.ImageDao.Get(id);
        }

        public IEnumerable<Image> GetByFilter()
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            this.ImageDao.Remove(id);
        }

        public void Update(Image item)
        {
            this.ImageDao.Update(item);
        }
    }
}