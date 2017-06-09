using Microsoft.Owin;
using Owin;
using System.Configuration;
using System.Web.Services.Description;

[assembly: OwinStartupAttribute(typeof(Manager.Startup))]
namespace Manager
{
    public partial class Startup
    {
		public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
