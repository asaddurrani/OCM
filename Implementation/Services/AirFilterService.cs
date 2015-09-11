using Interfaces.IServices;
using Interfaces.Repository;
using Models.DomainModels;
using Models.ResponseModels;

namespace Implementation.Services
{
    public class AirFilterService: IAirFilterService
    {
         private readonly IAirFilterRepository _airFilterRepository;

         public AirFilterService(IAirFilterRepository airFilterRepository)
        {
            this._airFilterRepository = airFilterRepository;

        }

        public AirFilterResponse GetAllAirFilters()
        {
            return _airFilterRepository.GetAllAirFilters();
        }

        public AirFilter GetAirFilterById(int id)
        {
            return _airFilterRepository.GetAirFilterById(id);
        }
    }
}
