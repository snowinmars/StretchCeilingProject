using StretchCeilingProject.Entity;
using System;
using System.Collections.Generic;

namespace StretchCeilingProject.DAL
{
    public class ImageDao : IDao<Image>
    {
        public void Add(Image item)
        {
            throw new NotImplementedException();
        }

        public Image Get(Guid id)
        {
            return new Image(new byte[0]);
        }

        public IEnumerable<Image> GetByFilter()
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Image item)
        {
            throw new NotImplementedException();
        }
    }
}