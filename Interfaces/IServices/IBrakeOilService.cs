using Models.ResponseModels;

namespace Interfaces.IServices
{
    public interface IBrakeOilService
    {
        BrakeOilResponse GetAllBrakeOils();
        Models.DomainModels.BrakeOil GetBrakeOilById(int id);
    }
}
