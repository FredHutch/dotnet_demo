using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dotnet_demo.Startup))]
namespace dotnet_demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
