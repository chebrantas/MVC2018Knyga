using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC2018Knyga.Startup))]
namespace MVC2018Knyga
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
