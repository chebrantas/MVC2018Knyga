using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC2018Knyga.Models;

namespace MVC2018Knyga.Controllers
{
    public class HomeController : Controller
    {
        private MusicStoreDB db = new MusicStoreDB();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
       
        public ActionResult Search(string q)
        {
            var album = db.Albums.Include("Artist").Where(a => a.Title.Contains(q)).Take(10);
            return View(album);
        }
    }
}