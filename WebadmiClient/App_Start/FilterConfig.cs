using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebadmiClient.Filters;

namespace WebadmiClient
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new AutenticacionRequeridaAttribute());
            filters.Add(new HandleErrorAttribute());
        }

        //public class MvcApplication : HttpApplication
        //{
        //    protected void Application_Start()
        //    {
        //        AreaRegistration.RegisterAllAreas();
        //        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        //        RouteConfig.RegisterRoutes(RouteTable.Routes);
        //        BundleConfig.RegisterBundles(BundleTable.Bundles);
        //    }
        //}
    }
}
