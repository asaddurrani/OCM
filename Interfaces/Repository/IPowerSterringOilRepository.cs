using Models.DomainModels;
using Models.ResponseModels;

namespace Interfaces.Repository
{
    public interface IPowerSterringOilRepository : IBaseRepository<Models.DomainModels.PowerSterringOil, int>
    {
        PowerSterringOilResponse GetAllOils();
        PowerSterringOil GetPowerSterringOilById(int id);
        PowerSterringOil Save(PowerSterringOil powerSterringOil);
    }
}
