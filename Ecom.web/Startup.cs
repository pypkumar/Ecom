using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ecom.web.Startup))]
namespace Ecom.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
