using Models.DomainModels;
using Models.ResponseModels;

namespace Interfaces.IServices
{
    public interface IOilService
    {
        OilResponse GetAllOils(Models.RequestModels.OilSearchRequest request);
        Oil GetOilById(int id);
        Oil Save(Oil oil);
        OilResponse GetAll();
    }
}
