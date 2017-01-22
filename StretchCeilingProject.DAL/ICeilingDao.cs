using StretchCeilingProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StretchCeilingProject.DAL
{
    public interface ICeilingDao : IDao<Celling, CellingFilter>
    {
        IEnumerable<IGrouping<CellingCategory, Celling>> GetGroupedByCategory();

        CellingDescription GetDescription(Guid id);
    }
}