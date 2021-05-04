using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebsitePrototype.Startup))]
namespace WebsitePrototype
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
