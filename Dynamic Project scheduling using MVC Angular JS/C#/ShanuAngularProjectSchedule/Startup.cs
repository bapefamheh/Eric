using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectScheduler.Startup))]
namespace ProjectScheduler
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
