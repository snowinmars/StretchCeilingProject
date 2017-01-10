using System;
using StretchCeilingProject.Common;

namespace StretchCeilingProject.Entity
{
    public class Image
    {
        public Image(byte[] content, string mimeType = Constant.MIMEType)
        {
            this.Content = content;
            this.MIMEType = mimeType;

            this.Id = Guid.NewGuid();
        }

        public byte[] Content { get; }

        public string MIMEType { get; }
        public Guid Id { get; set; }
    }
}