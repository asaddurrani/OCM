using Interfaces.IServices;
using Interfaces.Repository;
using Models.DomainModels;
using Models.ResponseModels;
using Repository.Repositories;

namespace Implementation.Services
{
    public class OilMakerService: IOilMakerService
    {
        private readonly IOilMakerCompanyRepository oilMakerCompanyRepository;

        public OilMakerService(IOilMakerCompanyRepository oilMakerCompanyRepository)
        {
            this.oilMakerCompanyRepository = oilMakerCompanyRepository;

        }

        public OilMakerResponce GetAllOilMakers()
        {
            return oilMakerCompanyRepository.GetAllOilMakers();
        }

        public OilMakerCompany GetOilMakerCompanyById(int id)
        {
            return oilMakerCompanyRepository.GetOilMakerCompanyById(id);
        }
    }
}
