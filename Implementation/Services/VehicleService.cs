using Interfaces.IServices;
using Interfaces.Repository;
using Models.DomainModels;
using Models.ResponseModels;

namespace Implementation.Services
{
    public class VehicleService: IVehicleMakerService
    {
        private readonly IVehicleMakerRepository vehicleMakerRepository;

        public VehicleService(IVehicleMakerRepository vehicleMakerRepository)
        {
            this.vehicleMakerRepository = vehicleMakerRepository;

        }

        public VehicalMakerResponse GetAllVehicleMakers()
        {
            return vehicleMakerRepository.GetAllVehicleMakers();
        }

        public VehicleMaker GetVehicleById(int id)
        {
            return vehicleMakerRepository.GetVehicleById(id);
        }
    }
}
