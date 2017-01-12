using StretchCeilingProject.Common;
using StretchCeilingProject.DAL;
using StretchCeilingProject.Entity;
using System;
using System.Collections.Generic;

namespace StretchCeilingProject.BLL
{
    public class ImageLogic : IImageLogic
    {
        public ImageLogic(IImageDao imageDao)
        {
            this.ImageDao = imageDao;
        }

        private IImageDao ImageDao { get; }

        public void Add(Image item)
        {
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
            if (item.Content.Length <= 0 ||
                item.Content.Length > Constant.MaxImageLengthInBytes ||
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

        public void Remove(Guid id)
        {
            this.ImageDao.Remove(id);
        }

        public void Update(Image item)
        {
            this.ImageDao.Update(item);
        }

        public IEnumerable<Image> GetByFilter(ImageFilter filter)
        {
            throw new NotImplementedException();
        }
    }
}