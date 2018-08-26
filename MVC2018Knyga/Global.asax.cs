using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MVC2018Knyga.Models;

namespace MVC2018Knyga
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //inicializuojama kada perkurit DB ar visada ar tik kai modelis pasikeicia
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MusicStoreDB>());
            Database.SetInitializer(new MusicStoreDbInitializer());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
