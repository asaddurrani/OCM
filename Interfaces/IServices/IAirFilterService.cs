using Models.ResponseModels;

namespace Interfaces.IServices
{
    public interface IAirFilterService
    {
        AirFilterResponse GetAllAirFilters();
        Models.DomainModels.AirFilter GetAirFilterById(int id);
    }
}
