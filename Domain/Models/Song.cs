using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Song : MediaFile
    {

        // FIELDS
        private int year;
        private string album;
        private List<Artist> artists;
        private List<Genre> genres;
        private int lenght;

        // PROPERTIES

        public int Year
        {
            get { return year; }
            private set { year = value; }
        }
        public string Album
        {
            get { return album; }
            private set { album = value; }
        }
        public List<Artist> Artists
        {
            get { return artists; }
            private set { artists = value; }
        }
        public List<Genre> Genres
        {
            get { return genres; }
            private set { genres = value; }
        }
        public int Length
        {
            get { return lenght; }
            private set { lenght = value; }
        }

        // CONSTRUCTORS
        public Song()
        {
            artists = new List<Artist>();
            genres = new List<Genre>();
        }
        public Song(int id, string title, string path, int length, string album, int year, List<Artist> artists, List<Genre> genres, List<Tag> tags) : base(id, title, path, tags)
        {
            this.lenght = length;
            this.album = album;
            this.year = year;
            this.artists = artists;
            this.genres = genres;
        }
    }
}
