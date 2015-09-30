using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectForum.Startup))]
namespace ProjectForum
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
