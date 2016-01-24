using Interfaces.IServices;
using Interfaces.Repository;
using Models.DomainModels;
using Models.ResponseModels;


namespace Implementation.Services
{
    public class OilFilterService: IOilFilterService
    {
        private readonly IOilFilterRepository _oilFilterRepository;
        public OilFilterService(IOilFilterRepository oilFilterRepository)
        {
            this._oilFilterRepository = oilFilterRepository;
        }
        public OilFilterResponse GetAllOilFilters()
        {
            return _oilFilterRepository.GetAllOilFilters();
        }

        public OilFilter GetOilFilterById(int id)
        {
            return _oilFilterRepository.GetOilFilterById(id);
        }
        public OilFilter Save(OilFilter oil)
        {
            var oilFilterReturn = _oilFilterRepository.Save(oil);
            return oilFilterReturn;
        }
    }
}
