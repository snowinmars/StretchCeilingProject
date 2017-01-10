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

        public const int MaxImageLengthInBytes = 4*1024*1024; // 4 Mb

        public const string ConnectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    }
}