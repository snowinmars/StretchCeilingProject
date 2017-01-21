using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StretchCeilingProject.Entity
{
    public class CellingDescription
    {
        public CellingDescription()
        {
            this.Procs = new List<string>();
            this.ImageIds = new List<Guid>();
        }

        public Guid Id { get; set; }
        public string Description { get; set; }
        public IList<string> Procs { get; }
        public IList<Guid> ImageIds { get; }

        public static CellingDescription Empty
        {
            get
            {
                return new CellingDescription
                {
                    Description = "",
                };
            }
        }
    }
}
