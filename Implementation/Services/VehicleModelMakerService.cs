using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.IServices;
using Interfaces.Repository;
using Models.DomainModels;
using Models.RequestModels;
using Models.ResponseModels;

namespace Implementation.Services
{
    public class VehicleModelMakerService : IVehicleModelMakerService
    {
        private readonly IVehicleModelMakerRepository vehicleModelMakerRepository;

        public VehicleModelMakerService(IVehicleModelMakerRepository vehicleModelMakerRepository)
        {
            this.vehicleModelMakerRepository = vehicleModelMakerRepository;
        }
        public VehicleModelMakerResponse GetAllVehicleModelMakers(VehicleModelMakerSearchRequest vehicleModelMakerSearchRequest)
        {
            return vehicleModelMakerRepository.GetAllVehicles(vehicleModelMakerSearchRequest);
        }

        public VehicleModelMaker GetVehicleModelMakerById(int id)
        {
            return vehicleModelMakerRepository.GetVehicleById(id);
        }
    }
}
