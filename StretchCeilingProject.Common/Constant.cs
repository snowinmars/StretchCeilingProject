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

            MIMEType = "image/png";
        }

        public static IEnumerable<Guid> CarouselImagesIds;
        public static string MIMEType;
    }
}
