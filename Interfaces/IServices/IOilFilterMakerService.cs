using Models.DomainModels;
using Models.ResponseModels;

namespace Interfaces.IServices
{
    public interface IOilFilterMakerService
    {
        OilFilterMakerResponse GetAllOilFilters(Models.RequestModels.OilFilterMakerSearchRequest request);
        OilFilterMakerCompany GetOilFilterById(int id);
        OilFilterMakerCompany Save(OilFilterMakerCompany oil);
        OilFilterMakerResponse GetAll();
    }
}
