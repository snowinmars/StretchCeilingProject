using System.Collections.Generic;
using System.Linq;
using StretchCeilingProject.Entity;

namespace StretchCeilingProject.BLL
{
    public interface ICellingLogic : ILogic<Celling, CellingFilter>
    {
        IEnumerable<IGrouping<CellingCategory, Celling>> GetGroupedByCategory();
    }
}