using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MegiddoLionsWebApp.Startup))]
namespace MegiddoLionsWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
