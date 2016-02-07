using Interfaces.IServices;
using Interfaces.Repository;
using Models.DomainModels;
using Models.ResponseModels;


namespace Implementation.Services
{
    public class OilFilterMakerService : IOilFilterMakerService
    {
         private readonly IOilFilterMakerRepository _oilFilterMakerRepository;

        public OilFilterMakerService(IOilFilterMakerRepository oilFilterMakerRepository)
        {
            _oilFilterMakerRepository = oilFilterMakerRepository;
        }


        public OilFilterMakerResponse GetAllOilFilters(Models.RequestModels.OilFilterMakerSearchRequest request)
        {
            return _oilFilterMakerRepository.GetAllOilFilterMakerCompanies();
        }

        public OilFilterMakerCompany GetOilFilterById(int id)
        {
            return _oilFilterMakerRepository.GetOilFilterMakerCompanyById(id);
        }

        public OilFilterMakerCompany Save(OilFilterMakerCompany oil)
        {
            throw new System.NotImplementedException();
        }

        public OilFilterMakerResponse GetAll()
        {
            return _oilFilterMakerRepository.GetAllOilFilterMakerCompanies();
        }
    }
}
