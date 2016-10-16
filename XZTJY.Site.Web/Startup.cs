using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XZTJY.Site.Web.Startup))]
namespace XZTJY.Site.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
