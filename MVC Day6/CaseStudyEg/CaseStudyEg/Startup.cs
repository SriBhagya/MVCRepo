using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CaseStudyEg.Startup))]
namespace CaseStudyEg
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
