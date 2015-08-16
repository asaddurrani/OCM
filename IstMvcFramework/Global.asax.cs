using IdentitySample.Models;
using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using IstMvcFramework.App_Start;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;
using WebBase.WebAPI;
using System.Web.Http;
using WebBase.UnityConfiguration;

namespace IdentitySample
{
    // Note: For instructions on enabling IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=301868
    public class MvcApplication : System.Web.HttpApplication
    {
        private static IUnityContainer container;
        protected void Application_Start()
        {
            RegisterIoC();
            AreaRegistration.RegisterAllAreas();
            RegisterApplicationWithIoC();
          
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            
            // Setup Json formatter
            GlobalConfiguration.Configuration.Formatters[0] = new JsonNetFormatter(null);
        }

        private void RegisterApplicationWithIoC()
        {
            // Set MVC resolver
            DependencyResolver.SetResolver(new WebBase.UnityConfiguration.UnityDependencyResolver(container));
            // Set Web Api resolver
            GlobalConfiguration.Configuration.DependencyResolver = new WebBase.UnityConfiguration.UnityDependencyResolver(container);
        }
        /// <summary>
        /// Register types with the IoC
        /// </summary>
        private static void RegisterTypes()
        {
            WebBase.TypeRegistrations.RegisterTypes(container);
            Implementation.TypeRegistrations.RegisterType(container);
            
        }
        /// <summary>
        /// Register unity 
        /// </summary>
        public static void RegisterIoC()
        {
            if (container == null)
            {
                container = CreateUnityContainer();
            }
        }
        /// <summary>
        /// Create the unity container
        /// </summary>
        private static IUnityContainer CreateUnityContainer()
        {
            container = WebBase.UnityConfiguration.UnityWebActivator.Container;
            RegisterTypes();

            return container;
        }

    }
}
