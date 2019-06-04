using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Seikluspark.Startup))]
namespace Seikluspark
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
