using Microsoft.Owin;
using Owin;
using System.Data.Entity;
using TPWEB_Residual.Models;

[assembly: OwinStartupAttribute(typeof(TPWEB_Residual.Startup))]
namespace TPWEB_Residual
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //Database.SetInitializer<ApplicationDbContext>(new DataDBInitializer());
        }
    }
}
