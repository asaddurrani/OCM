using Models.ResponseModels;


namespace Interfaces.Repository
{
        public interface IVehicleMakerRepository : IBaseRepository<Models.DomainModels.VehicleMaker, int>
    {
        VehicalMakerResponse GetAllVehicleMakers();
        Models.DomainModels.VehicleMaker GetVehicleById(int id);
    }
}
