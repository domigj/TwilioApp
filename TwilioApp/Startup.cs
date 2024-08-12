using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TwilioApp.Startup))]
namespace TwilioApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
