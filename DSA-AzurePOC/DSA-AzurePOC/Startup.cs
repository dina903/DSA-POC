using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DSA_AzurePOC.Startup))]
namespace DSA_AzurePOC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
