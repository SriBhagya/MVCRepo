using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrjFilterEg.Startup))]
namespace PrjFilterEg
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
