using System.Collections.Generic;

namespace Domain.Models
{
    public class Genre
    {

        // FIELDS
        private int _id;
        private string _name;

        // PROPERTIES
        public int Id
        {
            get { return _id; }
        }
        public string Name
        {
            get { return _name; }
        }
        // CONSTRUCTORS
        public Genre(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
