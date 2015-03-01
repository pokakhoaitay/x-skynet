using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(x_skynet.Web.Startup))]
namespace x_skynet.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
