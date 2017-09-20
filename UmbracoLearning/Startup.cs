using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UmbracoLearning.Startup))]
namespace UmbracoLearning
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
