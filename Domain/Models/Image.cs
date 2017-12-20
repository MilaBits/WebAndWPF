using System.Collections.Generic;

namespace Domain.Models
{
    public class Image : MediaFile
    {

        // FIELDS
        private int height;

        private int width;

        // PROPERTIES
        public int Height
        {
            get { return height; }
            private set { height = value; }
        }

        public int Width
        {
            get { return width; }
            private set { width = value; }
        }

        public Image(int id, string title, string path, int height, int width, List<Tag> tags) : base(id, title, path, tags)
        {
            this.height = height;
            this.width = width;
        }
    }
}
