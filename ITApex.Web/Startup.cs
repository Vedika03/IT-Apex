using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITApex.Web.Startup))]
namespace ITApex.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
