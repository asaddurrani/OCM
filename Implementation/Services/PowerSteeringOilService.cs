using Interfaces.IServices;
using Interfaces.Repository;
using Models.DomainModels;
using Models.ResponseModels;


namespace Implementation.Services
{
    public class PowerSteeringOilService: IPowerSteeringOilService
    {
        private readonly IPowerSterringOilRepository _powerSterringOilRepository;
        public PowerSteeringOilService(IPowerSterringOilRepository powerSterringOilRepository)
        {
            this._powerSterringOilRepository = powerSterringOilRepository;
        }
        public PowerSterringOilResponse GetAllPowerSterringOils()
        {
            return _powerSterringOilRepository.GetAllOils();
        }

        public PowerSterringOil GetPowerSterringOilById(int id)
        {
            return _powerSterringOilRepository.GetPowerSterringOilById(id);
        }

        public PowerSterringOil Save(PowerSterringOil oil)
        {
            return _powerSterringOilRepository.Save(oil);
        }
    }
}
