using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FootballProject.Startup))]
namespace FootballProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
