using System;

namespace NekoForms
{
    public class ImageProfile
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public long Size { get; set; }
        public DateTime CreationDate { get; set; }

        public ImageProfile(string name, int width, int height, long size, DateTime creationDate)
        {
            this.Name = name;
            this.Width = width;
            this.Height = height;
            this.Size = size;
            this.CreationDate = creationDate;
        }
    }
}
