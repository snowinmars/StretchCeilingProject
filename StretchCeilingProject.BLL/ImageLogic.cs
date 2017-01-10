using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StretchCeilingProject.DAL;

namespace StretchCeilingProject.BLL
{
    public class ImageLogic
    {
        public ImageLogic(ImageDao imageDao)
        {
            this.ImageDao = imageDao;
        }

        private ImageDao ImageDao { get; }

        public byte[] Get(Guid id)
        {
            return ImageDao.Get(id);
        }

        public void Add(byte[] content)
        {
            ImageDao.Add(content);
        }
    }
}
