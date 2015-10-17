using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoLWD.Startup))]
namespace LoLWD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
