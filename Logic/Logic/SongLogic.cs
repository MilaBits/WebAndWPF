using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.IRepositories;
using Domain.Models;
using Logic.Interfaces;

namespace Logic.Logic
{
    public class SongLogic : ISongLogic
    {
        public ISongRepository songRepo { get; private set; }

        public SongLogic(ISongRepository songRepo)
        {
            this.songRepo = songRepo;
        }

        public List<Song> GetAllSongs()
        {
            return songRepo.GetAllSongs();
        }

        public List<Song> SearchSongs(string search)
        {
            return songRepo.SearchSongs(search);
        }
    }
}
