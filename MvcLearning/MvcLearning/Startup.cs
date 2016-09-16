using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcLearning.Startup))]
namespace MvcLearning
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
