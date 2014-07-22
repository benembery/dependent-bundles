using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DependentBundles.Tests.Web.Startup))]
namespace DependentBundles.Tests.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
