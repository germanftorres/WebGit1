using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebGit1.Startup))]
namespace WebGit1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
