using System.Collections.Generic;

namespace Domain.Models
{
    public abstract class MediaFile
    {

        // Fields
        private int id;
        private string title;
        private string path;
        private List<Tag> tags;

        // Properties
        public int Id
        {
            get { return id; }
        }
        public string Title
        {
            get { return title; }
            private set { title = value; }
        }
        public string Path
        {
            get { return path; }
            private set { path = value; }
        }
        public List<Tag> Tags
        {
            get { return tags; }
            private set { tags = value; }
        }

        // Constructor
        public MediaFile()
        {
            this.id = 0;
            this.title = string.Empty;
            this.path = string.Empty;
        }

        public MediaFile(int id, string title, string path, List<Tag> tags)
        {
            this.id = id;
            this.title = title;
            this.path = path;
            this.tags = tags;
        }

        public override string ToString()
        {
            return title;
        }           
    }
}
