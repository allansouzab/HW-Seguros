using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HardWorkSegurosWebSite.Startup))]
namespace HardWorkSegurosWebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
