using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC2018Knyga.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            ViewBag.Message = "aaaa";
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
    }
}