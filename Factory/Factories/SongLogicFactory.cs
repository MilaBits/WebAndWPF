using DataAccess.Contexts;
using DataAccess.Repositories;
using Logic.Interfaces;
using Logic.Logic;

namespace Factory.Factories
{
    public class SongLogicFactory
    {
        public static ISongLogic GetSongLogic()
        {
            return new SongLogic(new SongRepository(new SongSqlContext()));
        }
    }
}
