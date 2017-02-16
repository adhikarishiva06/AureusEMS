using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AureusEMS.Web.Startup))]
namespace AureusEMS.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
