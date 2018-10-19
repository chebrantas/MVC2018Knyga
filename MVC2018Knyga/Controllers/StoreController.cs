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
            var albums = GetAlbums();
            return View(albums);
        }

        [Authorize]
        public ActionResult Buy(int id)
        {
            var album = GetAlbums().Single(a => a.AlbumId == id);
            return View(album);
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

        private static List<Album> GetAlbums()
        {
            var albums = new List<Album>
            {
                new Album { AlbumId = 1, Title = "The Fall of March1", Price=9.99M },
                new Album { AlbumId = 2, Title = "The Fall of March2", Price = 8.99M },
                new Album { AlbumId = 3, Title = "The Fall of March3", Price = 7.99M },
                new Album { AlbumId = 4, Title = "The Fall of March4", Price = 6.99M },
                new Album { AlbumId = 5, Title = "The Fall of March5", Price = 5.99M },
            };
            return albums;
        }
    }
}