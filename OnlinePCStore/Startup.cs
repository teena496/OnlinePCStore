using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlinePCStore.Startup))]
namespace OnlinePCStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
