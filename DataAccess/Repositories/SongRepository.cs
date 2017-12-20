using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.IContexts;
using DataAccess.IRepositories;
using Domain.Models;

namespace DataAccess.Repositories
{
    public class SongRepository : ISongRepository
    {
        public ISongContext context { get; private set; }
        public SongRepository(ISongContext context)
        {
            this.context = context;
        }

        public List<Song> GetAllSongs()
        {
            return context.GetAllSongs();
        }

        public List<Song> SearchSongs(string search)
        {
            return context.SearchSongs(search);
        }
    }
}
