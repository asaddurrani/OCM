﻿using Implementation.Identity;
using Implementation.Services;
using Interfaces.IServices;
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
            unityContainer.RegisterType<IAirFilterService, AirFilterService>();
            unityContainer.RegisterType<IOilFilterService, OilFilterService>();
            unityContainer.RegisterType<IPowerSteeringOilService, PowerSteeringOilService>();
            unityContainer.RegisterType<IBrakeOilService, BrakeOilService>();
            unityContainer.RegisterType<IOilFilterMakerService, OilFilterMakerService>();
            unityContainer.RegisterType<IUserStore<ApplicationUsers>, UserStore<ApplicationUsers>>();
            
        }
    }
}
