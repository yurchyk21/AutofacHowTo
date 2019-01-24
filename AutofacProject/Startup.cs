using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutofacProject.Startup))]
namespace AutofacProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
