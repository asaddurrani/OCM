using Models.DomainModels;
using Models.RequestModels;
using Models.ResponseModels;

namespace Interfaces.Repository
{
    public interface IVehicleModelMakerRepository : IBaseRepository<VehicleModelMaker, int>
    {
        VehicleModelMakerResponse GetAllVehicles(VehicleModelMakerSearchRequest vehicleModelMakerSearchRequest);
        VehicleModelMaker GetVehicleById(int id);
    }
}
