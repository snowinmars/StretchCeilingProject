using StretchCeilingProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StretchCeilingProject.BLL
{
    public interface ICellingLogic : ILogic<Celling, CellingFilter>
    {
        IEnumerable<IGrouping<CellingCategory, Celling>> GetGroupedByCategory();

        CellingDescription GetDescription(Guid id);
    }
}