using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CIC.Web.Startup))]
namespace CIC.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
