using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCControlsDemo.Startup))]
namespace MVCControlsDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
