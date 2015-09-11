using Interfaces.IServices;
using Interfaces.Repository;
using Models.DomainModels;
using Models.ResponseModels;


namespace Implementation.Services
{
    public class BrakeOilService: IBrakeOilService
    {
        private readonly IBrakeOilRepository _brakeOilRepository;
        public BrakeOilService(IBrakeOilRepository brakeOilRepository)
        {
            this._brakeOilRepository = brakeOilRepository;
        }
        public BrakeOilResponse GetAllBrakeOils()
        {
            return _brakeOilRepository.GetAllBrakeOils();
        }

        public BrakeOil GetBrakeOilById(int id)
        {
            return _brakeOilRepository.GetBrakeOilById(id);
        }
    }
}
