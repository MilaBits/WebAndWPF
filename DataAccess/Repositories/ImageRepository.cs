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
    public class ImageRepository : IImageRepository
    {
        public IImageContext context { get; private set; }

        public List<Image> GetAllImages()
        {
            return context.GetAllImages();
        }

        public List<Image> SearchImages(string search)
        {
            return context.SearchImages(search);
        }

        public ImageRepository(IImageContext context)
        {
            this.context = context;
        }
    }
}
