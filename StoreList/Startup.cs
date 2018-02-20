using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StoreList.Startup))]
namespace StoreList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
