using Models.RequestModels;
using Models.ResponseModels;

namespace Interfaces.IServices
{
    public interface IVehicleModelMakerService
    {
        VehicleModelMakerResponse GetAllVehicleModelMakers(VehicleModelMakerSearchRequest vehicleModelMakerSearchRequest);
        Models.DomainModels.VehicleModelMaker GetVehicleModelMakerById(int id);
    }
}
