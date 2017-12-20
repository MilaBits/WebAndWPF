using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace DataAccess.IContexts
{
    public interface ISongContext
    {
        List<Song> GetAllSongs();
        List<Song> SearchSongs(string search);
    }
}
