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
    public class ImageLogic : IImageLogic
    {
        public IImageRepository imageRepo { get; private set; }

        public ImageLogic(IImageRepository imageRepo)
        {
            this.imageRepo = imageRepo;
        }

        public List<Image> GetAllImages()
        {
            return imageRepo.GetAllImages();
        }

        public List<Image> SearchImages(string search)
        {
            return imageRepo.SearchImages(search);
        }
    }
}
