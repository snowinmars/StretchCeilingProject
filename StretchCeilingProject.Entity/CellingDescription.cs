using System;
using System.Collections.Generic;

namespace StretchCeilingProject.Entity
{
    public class CellingDescription
    {
        public CellingDescription()
        {
            this.Procs = new List<string>();
            this.ImageIds = new List<string>();
        }

        public Guid Id { get; set; }
        public string Description { get; set; }
        public IList<string> Procs { get; }
        public IList<string> ImageIds { get; }

        public static CellingDescription Empty
        {
            get
            {
                return new CellingDescription
                {
                    Description = "",
                };
            }
        }
    }
}