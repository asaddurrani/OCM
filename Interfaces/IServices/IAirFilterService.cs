using Models.DomainModels;
using Models.ResponseModels;

namespace Interfaces.IServices
{
    public interface IAirFilterService
    {
        AirFilterResponse GetAllAirFilters();
        AirFilter GetAirFilterById(int id);
        AirFilter Save(AirFilter oil);
    }
}
