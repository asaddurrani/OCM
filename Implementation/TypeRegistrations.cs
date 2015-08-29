using Implementation.Identity;
using Implementation.Services;
using Interfaces.IServices;
using Interfaces.Operation;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Practices.Unity;
using Models.IdentityModels;

namespace Implementation
{
    public static class TypeRegistrations
    {
        public static void RegisterType(IUnityContainer unityContainer)
        {
            UnityConfig.UnityContainer = unityContainer;
            Repository.TypeRegistrations.RegisterType(unityContainer);
            unityContainer.RegisterType<IProductService, ProductService>();
            unityContainer.RegisterType<IVehicleMakerService, VehicleService>();
            unityContainer.RegisterType<IVehicleModelMakerService, VehicleModelMakerService>();
            unityContainer.RegisterType<ICategoryService, CategoryService>();
            unityContainer.RegisterType<IOilMakerService, OilMakerService>();
            unityContainer.RegisterType<IOilService, OilService>();
            unityContainer.RegisterType<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>();
            
        }
    }
}
