using System;
using System.Collections.Generic;
using Domain.Models;

namespace DataAccess.IRepositories
{
    public interface IImageRepository
    {
        List<Image> GetAllImages();
        List<Image> SearchImages(string search);
    }
}
