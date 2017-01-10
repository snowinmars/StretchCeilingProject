using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StretchCeilingProject.Common;

namespace StretchCeilingProject.Entity
{
    public class Image
    {
        public Image(byte[] content, string mimeType = Constant.MIMEType)
        {
            this.Content = content;
            this.MIMEType = mimeType;
        }

        public byte[] Content { get; }

        public string MIMEType { get; }
    }
}
