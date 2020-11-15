using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UnderstandingSecuritySolution.Startup))]
namespace UnderstandingSecuritySolution
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
