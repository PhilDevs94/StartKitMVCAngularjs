using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(StartMVCAngularJS.Web.Startup))]
namespace StartMVCAngularJS.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
