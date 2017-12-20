using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.IContexts;
using Domain.Enums;
using Domain.Models;

namespace DataAccess.Contexts
{
    public class SongSqlContext : ISongContext
    {
        public List<Song> GetAllSongs()
        {
            return Database.GetSongs();
        }

        public List<Song> SearchSongs(string search)
        {
            return Database.SearchSongs(search);
        }
    }
}
