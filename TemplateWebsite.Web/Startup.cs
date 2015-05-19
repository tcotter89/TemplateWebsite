using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TemplateWebsite.Web.Startup))]
namespace TemplateWebsite.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
