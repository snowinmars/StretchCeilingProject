﻿using System;

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
                ImageUrl = string.Empty,
                Cost = string.Empty,
                Title = string.Empty,
                Description = string.Empty,
                Category = CellingCategory.None,
            };
        }

        public CellingCategory Category { get; set; }
        public Guid Id { get; set; }
        public string ImageUrl { get; set; }
        public string Cost { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public static Celling Empty { get; }
    }
}