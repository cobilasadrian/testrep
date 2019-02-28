using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestGitProject.Startup))]
namespace TestGitProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
