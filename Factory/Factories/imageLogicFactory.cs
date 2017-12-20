using DataAccess.Contexts;
using DataAccess.Repositories;
using Logic.Interfaces;
using Logic.Logic;

namespace Factory.Factories
{
    public class ImageLogicFactory
    {
        public static IImageLogic GetImageLogic()
        {
            return new ImageLogic(new ImageRepository(new ImageSqlContext()));
        }
    }
}
