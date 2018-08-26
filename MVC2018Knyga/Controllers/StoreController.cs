using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC2018Knyga.Models;

namespace MVC2018Knyga.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            ViewBag.Message = "Store/Index()";
            return View();
        }
        // GET: Store
        public string Browse()
        {
            return "Hello from Browse";
        }
        // GET: Store
        public string Details()
        {
            return "Hello from Details";
        }
        public ActionResult List()
        {
            var albums = new List<Album>();
            for (int i = 0; i < 10; i++)
            {
                albums.Add(new Album { Title = "Album " + i });
            }
            return View(albums);
        }
        public ActionResult Edit()
        {
            var albums = new List<Album>();
            for (int i = 0; i < 10; i++)
            {
                albums.Add(new Album { Title = "Album " + i });
            }
            return View(albums);
        }
    }
}