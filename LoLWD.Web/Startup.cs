using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoLWD.Web.Startup))]
namespace LoLWD.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
