using System;

namespace StretchCeilingProject.Entity
{
    public enum CellingCategory
    {
        None = 0,
        Celling = 1,
        Construction = 2,
        Another = 3,
    }

    public static class CellingCategoryExtension
    {
        public static string GetName(this CellingCategory cellingCategory)
        {
            switch (cellingCategory)
            {
                case CellingCategory.None:
                    return "Не указана";

                case CellingCategory.Celling:
                    return "Потолки";

                case CellingCategory.Construction:
                    return "Установка конструкции по периметру";

                case CellingCategory.Another:
                    return "Доп. услуги";

                default:
                    throw new ArgumentOutOfRangeException(nameof(cellingCategory), cellingCategory, null);
            }
        }
    }
}