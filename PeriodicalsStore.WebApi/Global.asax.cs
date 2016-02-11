using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace PeriodicalsStore.WebApi
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        }
    }
}
