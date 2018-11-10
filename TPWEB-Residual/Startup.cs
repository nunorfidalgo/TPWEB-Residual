using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TPWEB_Residual.Startup))]
namespace TPWEB_Residual
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
