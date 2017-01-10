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