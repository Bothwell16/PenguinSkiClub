using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PenguinComparison.Startup))]
namespace PenguinComparison
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
