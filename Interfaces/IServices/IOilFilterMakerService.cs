using Models.DomainModels;
using Models.ResponseModels;

namespace Interfaces.IServices
{
    public interface IOilFilterMakerService
    {
        OilFilterMakerResponse GetAllOilFilters(Models.RequestModels.OilFilterMakerSearchRequest request);
        OilFilter GetOilFilterById(int id);
        OilFilter Save(OilFilter oil);
        OilFilterMakerResponse GetAll();
    }
}
