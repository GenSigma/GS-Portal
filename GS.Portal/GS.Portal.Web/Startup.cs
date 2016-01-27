using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GS.Portal.Web.Startup))]
namespace GS.Portal.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
