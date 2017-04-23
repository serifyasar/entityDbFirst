using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(entityDbFirst.Startup))]
namespace entityDbFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
