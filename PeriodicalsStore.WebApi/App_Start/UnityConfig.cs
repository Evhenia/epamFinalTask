using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using BusinessServices.DomainLogic.Interfaces.Services;
using BusinessServices.DomainLogic.Services;

namespace PeriodicalsStore.WebApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            container.RegisterType<IThemeService, ThemeService>();
            container.RegisterType<IPeriodicalService, PeriodicalService>();
            //container.RegisterType<ISubscriptionService, SubscriptionService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);            
        }
    }
}