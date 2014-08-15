using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CookieMonster.Startup))]
namespace CookieMonster
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
