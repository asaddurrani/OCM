using Models.DomainModels;
using Models.ResponseModels;

namespace Interfaces.Repository
{
    public interface IOilFilterMakerRepository
    {
        OilFilterMakerResponse GetAllOilFilterMakerCompanies();
        OilFilterMakerCompany GetOilFilterMakerCompanyById(int id);
        OilFilterMakerCompany Save(OilFilterMakerCompany oil);
    }
}
