using System;
using System.Collections.Generic;
using System.Configuration;

namespace StretchCeilingProject.Common
{
    public static class Constant
    {
        public const string MIMEType = "image/png";

        public static IEnumerable<string> CarouselImagesUrls;

        static Constant()
        {
            Constant.CarouselImagesUrls = new[]
            {
                "https://pp.vk.me/c837538/v837538618/1f165/yViUFF64HAA.jpg",
                "https://pp.vk.me/c837538/v837538618/1f16e/W7AyMKoWJ3k.jpg",
                "https://pp.vk.me/c837538/v837538618/1f178/4PRxqDjg5ro.jpg",
                "https://pp.vk.me/c837538/v837538618/1f181/uPiQMv7-Ig0.jpg",
            };

            Constant.OurWorkImagesUrls = new[]
            {
                "https://pp.vk.me/c837538/v837538618/1f18e/gtaB_hpAO8k.jpg",
                "https://pp.vk.me/c837538/v837538618/1f197/aNZ65CvuBrg.jpg",
                "https://pp.vk.me/c837538/v837538618/1f1a0/7ZPA9chiGUY.jpg",
                "https://pp.vk.me/c837538/v837538618/1f1a9/YCtxjqox5t4.jpg",
                "https://pp.vk.me/c837538/v837538618/1f1b2/7_6hkq8E9Kw.jpg",
                "https://pp.vk.me/c837538/v837538618/1f1bb/kY6hO5iOKg0.jpg",
                "https://pp.vk.me/c837538/v837538618/1f1c4/Uswr4Oe86vc.jpg",
                "https://pp.vk.me/c837538/v837538618/1f1cd/NREZuW8LqMg.jpg",
            };
        }

        public static string[] OurWorkImagesUrls { get; set; }

        public const int MaxImageLengthInBytes = 4 * 1024 * 1024; // 4 Mb
        
        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["defaultDatabaseConnectionString"].ConnectionString;
    }
}