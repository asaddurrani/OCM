using System.Linq;
using Models.DomainModels;
using Models.ResponseModels;
namespace Interfaces.Repository
{
    public interface IOilRepository : IBaseRepository<Models.DomainModels.Oil, int>
    {
        OilResponse GetAllOils(Models.RequestModels.OilSearchRequest request);
        Oil GetOilById(int id);
        Oil Save(Oil oil);
        OilResponse GetAllRecords();
    }
}
