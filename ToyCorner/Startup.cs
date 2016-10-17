using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToyCorner.Startup))]
namespace ToyCorner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
