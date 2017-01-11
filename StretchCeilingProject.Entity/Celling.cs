using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StretchCeilingProject.Entity
{
    public class Celling
    {
        public Celling()
        {
            this.Id = Guid.NewGuid();
        }

        static Celling()
        {
            Celling.Empty = new Celling
            {
                Id = default(Guid),
                ImageId = default(Guid),
                Cost = 0,
                Description = string.Empty,
            };
        }

        public Guid  Id { get; set; }
        public Guid ImageId { get; set; }
        public float Cost { get; set; }
        public string Description { get; set; }
        public static Celling Empty { get; }
    }
}
