using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Factory.Factories;
using Logic.Interfaces;

namespace UIWeb.Controllers
{
    public class HomeController : Controller
    {
        public ISongLogic songLogic { get; private set; }
        public IImageLogic imageLogic { get; private set; }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Songs()
        {
            songLogic = SongLogicFactory.GetSongLogic();

            ViewBag.Message = "Your application description page.";

            return View(songLogic.GetAllSongs());
        }
        [HttpPost]
        public ActionResult Songs(string searchTerm)
        {
            songLogic = SongLogicFactory.GetSongLogic();
            return View(songLogic.SearchSongs(searchTerm));
        }

        public ActionResult Images()
        {
            imageLogic = ImageLogicFactory.GetImageLogic();

            ViewBag.Message = "Your contact page.";

            return View(imageLogic.GetAllImages());
        }

        [HttpPost]
        public ActionResult Images(string searchTerm)
        {
            imageLogic = ImageLogicFactory.GetImageLogic();
            return View(imageLogic.SearchImages(searchTerm));
        }
    }
}