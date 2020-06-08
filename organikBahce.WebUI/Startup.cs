using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(organikBahce.WebUI.Startup))]
namespace organikBahce.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
