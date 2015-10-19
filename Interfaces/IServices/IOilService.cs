using Models.DomainModels;
using Models.ResponseModels;

namespace Interfaces.IServices
{
    public interface IOilService
    {
        OilResponse GetAllOils();
        Oil GetOilById(int id);
        Oil Save(Oil oil);
    }
}
