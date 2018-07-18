using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GarbageCollectorV2.Startup))]
namespace GarbageCollectorV2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
