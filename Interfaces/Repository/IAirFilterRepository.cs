using Models.DomainModels;
using Models.ResponseModels;

namespace Interfaces.Repository
{
    public interface IAirFilterRepository : IBaseRepository<Models.DomainModels.AirFilter, int>
    {
        AirFilterResponse GetAllAirFilters();
        AirFilter GetAirFilterById(int id);
        AirFilter Save(AirFilter airFilter);
    }
}
