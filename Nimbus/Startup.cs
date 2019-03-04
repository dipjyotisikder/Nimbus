using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nimbus.Startup))]
namespace Nimbus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
