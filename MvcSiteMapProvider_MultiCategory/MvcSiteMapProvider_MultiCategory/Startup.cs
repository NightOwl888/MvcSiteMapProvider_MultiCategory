using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcSiteMapProvider_MultiCategory.Startup))]
namespace MvcSiteMapProvider_MultiCategory
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
