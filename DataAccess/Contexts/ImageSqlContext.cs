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
    public class ImageSqlContext : IImageContext
    {
        public List<Image> GetAllImages()
        {
            return Database.GetImages();
        }

        public List<Image> SearchImages(string search)
        {

            return Database.SearchImages(search);
        }
    }
}
