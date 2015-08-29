using Models.ResponseModels;
namespace Interfaces.IServices
{
    public interface IOilMakerService
    {
        OilMakerResponce GetAllOilMakers();
        Models.DomainModels.OilMakerCompany GetOilMakerCompanyById(int id);
    }
}
