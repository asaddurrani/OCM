using Implementation.Services;
using Interfaces.IServices;
using Microsoft.Practices.Unity;

namespace IstMvcFramework
{
    public static class TypeRegistrations
    {
        public static void RegisterType(IUnityContainer unityContainer)
        {

            //unityContainer.RegisterInstance<IAuthenticationManager, HttpContext.Current.GetOwinContext().Authentication>();
            unityContainer.RegisterType<IProductService, ProductService>(); 
            //unityContainer.RegisterType<IUserStore, ApplicationUser>();
      

        }
    }
}