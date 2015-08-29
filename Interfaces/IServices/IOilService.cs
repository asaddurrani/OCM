using Models.ResponseModels;

namespace Interfaces.IServices
{
    public interface IOilService
    {
        OilResponse GetAllOils();
        Models.DomainModels.Oil GetOilById(int id);
    }
}
