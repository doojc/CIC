using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CIC.Startup))]
namespace CIC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
