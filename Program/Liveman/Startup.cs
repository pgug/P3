using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Liveman.Startup))]
namespace Liveman
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
