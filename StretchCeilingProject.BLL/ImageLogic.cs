using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StretchCeilingProject.DAL;
using StretchCeilingProject.Entity;

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
            this.ImageDao.Add(item);
        }

        public Image Get(Guid id)
        {
            return this.ImageDao.Get(id);
        }

        public void Update(Image item)
        {
            this.ImageDao.Update(item);
        }

        public void Remove(Guid id)
        {
            this.ImageDao.Remove(id);
        }

        public IEnumerable<Image> GetByFilter()
        {
            throw new NotImplementedException();
        }
    }
}
