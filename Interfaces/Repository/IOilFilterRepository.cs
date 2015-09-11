using Models.DomainModels;
using Models.ResponseModels;

namespace Interfaces.Repository
{
    public interface IOilFilterRepository : IBaseRepository<Models.DomainModels.OilFilter, int>
    {
        OilFilterResponse GetAllOilFilters();
        OilFilter GetOilFilterById(int id);
    }
}
