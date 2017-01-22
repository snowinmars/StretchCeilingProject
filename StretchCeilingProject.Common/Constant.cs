using System;
using System.Collections.Generic;
using System.Configuration;

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
                new Guid(0,0,0,0,0,0,0,0,0,0,11),
                new Guid(0,0,0,0,0,0,0,0,0,0,12),
                new Guid(0,0,0,0,0,0,0,0,0,0,13),
                new Guid(0,0,0,0,0,0,0,0,0,0,14),
            };

            Constant.AnotherCarouselImagesIds = new[]
            {
                new Guid(0,0,0,0,0,0,0,0,0,0,2),
                new Guid(0,0,0,0,0,0,0,0,0,0,3),
                new Guid(0,0,0,0,0,0,0,0,0,0,4),
                new Guid(0,0,0,0,0,0,0,0,0,0,5),
                new Guid(0,0,0,0,0,0,0,0,0,0,6),
                new Guid(0,0,0,0,0,0,0,0,0,0,7),
                new Guid(0,0,0,0,0,0,0,0,0,0,8),
                new Guid(0,0,0,0,0,0,0,0,0,0,9),

            };
        }

        public static Guid[] AnotherCarouselImagesIds { get; set; }

        public const int MaxImageLengthInBytes = 4 * 1024 * 1024; // 4 Mb
        
        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["defaultDatabaseConnectionString"].ConnectionString;
    }
}