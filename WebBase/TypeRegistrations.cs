using System.Web.Mvc;
using Microsoft.Practices.Unity;
using WebBase.UnityConfiguration;

namespace WebBase
{
    public static class TypeRegistrations
    {
        public static void RegisterTypes(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType(typeof(IControllerActivator), typeof(UnityControllerActivator));
        }
    }
}
