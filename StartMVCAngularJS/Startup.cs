using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StartMVCAngularJS.Startup))]
namespace StartMVCAngularJS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
