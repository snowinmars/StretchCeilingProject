using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StretchCeilingProject.Entity
{
    public class CellingFilter
    {
        static CellingFilter()
        {
            Default = null;
        }

        public static CellingFilter Default { get; }
    }
}
