using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestForLink.Startup))]
namespace TestForLink
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
