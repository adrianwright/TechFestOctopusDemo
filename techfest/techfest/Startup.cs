using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(techfest.Startup))]
namespace techfest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
