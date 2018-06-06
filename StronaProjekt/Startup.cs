using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StronaProjekt.Startup))]
namespace StronaProjekt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
