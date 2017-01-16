using StretchCeilingProject.Entity;
using System.Collections.Generic;
using System.Linq;

namespace StretchCeilingProject.BLL
{
    public interface ICellingLogic : ILogic<Celling, CellingFilter>
    {
        IEnumerable<IGrouping<CellingCategory, Celling>> GetGroupedByCategory();
    }
}