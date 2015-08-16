using Models.ResponseModels;

namespace Interfaces.IServices
{
    public interface IVehicleMakerService
    {
        VehicalMakerResponse GetAllVehicleMakers();
        Models.DomainModels.VehicleMaker GetVehicleById(int id);
    }
}
