using System.Linq;
using Models.DomainModels;
using Models.ResponseModels;
namespace Interfaces.Repository
{
    public interface IOilRepository : IBaseRepository<Models.DomainModels.Oil, int>
    {
        OilResponse GetAllOils();
        Oil GetOilById(int id);
        Oil Save(Oil oil);
    }
}
