using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Three_M.Startup))]
namespace Three_M
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
