using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MVC2018Knyga.Models;

namespace MVC2018Knyga.Controllers
{
    public class ShoppingCartController : Controller
    {
        public ActionResult Index()
        {
            var products = new List<Product>();
            for (int i = 0; i < 10; i++) 
			{
                products.Add(new Product { Title = "Product " + i, Price = 1.13M * (i+2) });
            }

            //kai norim vienu modeliu (klase) perduoti daugiau duomenu nei standartine klase
            var model = new ShoppingCartViewModel 
			{ 
                Products = products,
                CartTotal = products.Sum(p=>p.Price),
                Message = "Thanks for your business!"
            };
                
            return View(model);
        }
      

    }
}
