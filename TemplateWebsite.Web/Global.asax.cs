using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TemplateWebsite.App_Start;
using TemplateWebsite.RepositoryLayer;

namespace TemplateWebsite.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start() {
            //NinjectWebCommon.bootstrapper.Kernel.Load(new DependencyInjection());
            //NinjectWebCommon.bootstrapper.Kernel.Load()
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
