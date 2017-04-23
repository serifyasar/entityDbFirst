using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(entityCodeFirst.Startup))]
namespace entityCodeFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
