using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CsiTest.Startup))]
namespace CsiTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
