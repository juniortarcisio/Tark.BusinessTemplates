using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TemplatesForBusiness.Startup))]
namespace TemplatesForBusiness
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
