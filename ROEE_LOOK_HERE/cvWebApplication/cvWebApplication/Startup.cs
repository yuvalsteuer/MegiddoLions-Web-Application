using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cvWebApplication.Startup))]
namespace cvWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
