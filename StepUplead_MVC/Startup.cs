using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StepUplead_MVC.Startup))]
namespace StepUplead_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
