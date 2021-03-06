﻿using System.Data.Entity;
using Interfaces.Repository;
using Microsoft.Practices.Unity;
using Repository.BaseRepository;
using Repository.Repositories;

namespace Repository
{
    public static class TypeRegistrations
    {
        public static void RegisterType(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<IProductRepository, ProductRepository>();
            unityContainer.RegisterType<IVehicleMakerRepository, VehicalMakerRepository>();
            unityContainer.RegisterType<IVehicleModelMakerRepository, VehicleModelMakerRepository>();
            unityContainer.RegisterType<ICategoryRepository, CategoryRepository>();
            unityContainer.RegisterType<ICustomerRepository, CustomerRepository>();
            unityContainer.RegisterType<ICustomerVehicleRepository, CustomerVehicleRepository>();
            unityContainer.RegisterType<IOilChangeRecordRepository, OilChangeRecordRepository>();
            unityContainer.RegisterType<IOilMakerCompanyRepository, OilMakerCompanyRepository>();
            unityContainer.RegisterType<IOilRepository, OilRepository>();
            unityContainer.RegisterType<IOilNetWeightRepository, OilNetWeightRepository>();
            unityContainer.RegisterType<IAirFilterRepository, AirFilterRepository>();
            unityContainer.RegisterType<IOilFilterRepository, OilFilterRepository>();
            unityContainer.RegisterType<IBrakeOilRepository, BrakeOilRepository>();
            unityContainer.RegisterType<IPowerSterringOilRepository, PowerSterringOilRepository>();
            unityContainer.RegisterType<IOilFilterMakerRepository, OilFilterMakerRepository>();


            unityContainer.RegisterType<DbContext, BaseDbContext>(new HierarchicalLifetimeManager());

            //unityContainer.RegisterType<IUser, ApplicationUser>();
        }
    }
}
