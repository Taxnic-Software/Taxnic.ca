using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ca.Taxnic.Web.Startup))]
namespace Ca.Taxnic.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
