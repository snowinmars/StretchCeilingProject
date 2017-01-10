using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StretchCeilingProject.Entity;

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
            return null;
        }

        public void Update(Image item)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Image> GetByFilter()
        {
            throw new NotImplementedException();
        }
    }
}
