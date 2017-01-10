using StretchCeilingProject.Common;
using System;

namespace StretchCeilingProject.Entity
{
    public class Image
    {
        private Image()
        {
            
        }

        public static Image Empty { get; }

        public Image(byte[] content)
        {
            this.Content = content;

            this.Id = Guid.NewGuid();
        }

        static Image()
        {
            Empty = new Image(new byte[0])
            {
                Id = default(Guid),
            };
        }

        public byte[] Content { get; }

        public Guid Id { get; set; }
    }
}