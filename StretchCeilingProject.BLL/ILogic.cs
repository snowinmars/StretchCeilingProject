using System.Collections.Generic;

namespace StretchCeilingProject.BLL
{
    public interface ILogic<T> : ICRUD<T>
    {
        IEnumerable<T> GetByFilter();
    }
}