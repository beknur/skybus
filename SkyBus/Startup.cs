using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SkyBus.Startup))]
namespace SkyBus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
