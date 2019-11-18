using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BNU_LaptopsMVC5.Startup))]
namespace BNU_LaptopsMVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
