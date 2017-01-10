using System;
using System.Collections.Generic;

namespace StretchCeilingProject.Common
{
    public static class Constant
    {
        public const string MIMEType = "image/png";

        public static IEnumerable<Guid> CarouselImagesIds;

        static Constant()
        {
            Constant.CarouselImagesIds = new[]
            {
                new Guid(0,0,0,0,0,0,0,0,0,0,1),
                new Guid(0,0,0,0,0,0,0,0,0,0,2),
                new Guid(0,0,0,0,0,0,0,0,0,0,3),
                new Guid(0,0,0,0,0,0,0,0,0,0,4),
            };
        }
    }
}