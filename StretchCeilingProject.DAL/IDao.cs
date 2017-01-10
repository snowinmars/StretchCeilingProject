using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StretchCeilingProject.DAL
{
    public interface IDao<T> : ICRUD<T>
    {
        IEnumerable<T> GetByFilter();
    }
}
