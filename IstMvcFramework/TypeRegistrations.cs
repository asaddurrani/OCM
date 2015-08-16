using Implementation.Services;
using Interfaces.IServices;
using Interfaces.Operation;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using Microsoft.Practices.Unity;
using Models.IdentityModels;
using System.Web;

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