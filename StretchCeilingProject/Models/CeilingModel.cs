using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StretchCeilingProject.Models
{
    public class CeilingModel
    {
        public Guid ImageId { get; set; }
        public float Cost { get; set; }
        public string Description { get; set; }
    }
}