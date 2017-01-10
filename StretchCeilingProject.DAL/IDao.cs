using System.Collections.Generic;

namespace StretchCeilingProject.DAL
{
    public interface IDao<T> : ICRUD<T>
    {
        IEnumerable<T> GetByFilter();
    }
}