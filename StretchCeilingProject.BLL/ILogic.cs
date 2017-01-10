using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StretchCeilingProject.BLL
{
    public interface ILogic<T> : ICRUD<T>
    {
        IEnumerable<T> GetByFilter();
    }
}
