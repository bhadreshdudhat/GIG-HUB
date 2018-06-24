using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GIG_HUB.Startup))]
namespace GIG_HUB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
