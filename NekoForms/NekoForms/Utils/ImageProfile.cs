namespace NekoForms
{
    using System;

    public class ImageProfile
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public DateTime CreationDate { get; set; }

        public ImageProfile(string name, int width, int height, DateTime creationDate)
        {
            this.Name = name;
            this.Width = width;
            this.Height = height;
            this.CreationDate = creationDate;
        }
    }
}
