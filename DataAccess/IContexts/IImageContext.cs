using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace DataAccess.IContexts
{
    public interface IImageContext
    {
        List<Image> GetAllImages();
        List<Image> SearchImages(string search);
    }
}
