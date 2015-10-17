using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoLWD.web.Startup))]
namespace LoLWD.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
