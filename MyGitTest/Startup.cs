using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyGitTest.Startup))]
namespace MyGitTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
