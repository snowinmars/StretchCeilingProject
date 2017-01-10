using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StretchCeilingProject.Common
{
    public static class Constant
    {
        static Constant()
        {
            CarouselImagesIds = new []
            {
                new Guid(0,0,0,0,0,0,0,0,0,0,1),
                new Guid(0,0,0,0,0,0,0,0,0,0,2),
                new Guid(0,0,0,0,0,0,0,0,0,0,3),
                new Guid(0,0,0,0,0,0,0,0,0,0,4),
            };

            
        }

        public static IEnumerable<Guid> CarouselImagesIds;
        public const string MIMEType = "image/png";
    }
}
