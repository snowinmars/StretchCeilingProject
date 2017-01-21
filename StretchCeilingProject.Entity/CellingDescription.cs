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

        public string Description { get; set; }
        public IEnumerable<string> Procs { get; }
        public IEnumerable<Guid> ImageIds { get; }
    }
}
