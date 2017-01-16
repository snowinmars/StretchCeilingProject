using System.Collections.Generic;
using System.Linq;
using StretchCeilingProject.Entity;

namespace StretchCeilingProject.DAL
{
    public interface ICeilingDao : IDao<Celling, CellingFilter>
    {
        IEnumerable<IGrouping<CellingCategory, Celling>> GetGroupedByCategory();
    }
}