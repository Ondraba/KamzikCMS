using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kamzik.Startup))]
namespace Kamzik
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
