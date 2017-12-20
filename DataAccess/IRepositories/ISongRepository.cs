using System;
using System.Collections.Generic;
using Domain.Models;

namespace DataAccess.IRepositories
{
    public interface ISongRepository
    {
        List<Song> GetAllSongs();
        List<Song> SearchSongs(string search);
    }
}
