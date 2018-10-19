using System.Web;
using System.Web.Mvc;

namespace MVC2018Knyga
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //idedame authorization visam turiniui norint kad kazkuriai vietai nereiktu reikia atributo [AllowAnonymous]
            //filters.Add(new System.Web.Mvc.AuthorizeAttribute());
            filters.Add(new HandleErrorAttribute());
        }
    }
}
