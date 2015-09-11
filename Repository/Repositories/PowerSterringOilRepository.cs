using System.Data.Entity;
using System.Linq;
using Interfaces.Repository;
using Microsoft.Practices.Unity;
using Models.DomainModels;
using Models.ResponseModels;
using Repository.BaseRepository;

namespace Repository.Repositories
{
    public class PowerSterringOilRepository : BaseRepository<PowerSterringOil>, IPowerSterringOilRepository
    {
        public PowerSterringOilRepository(IUnityContainer container) : base(container)
        {
        }

        protected override IDbSet<PowerSterringOil> DbSet
        {
            get { return db.PowerSterringOils; }
        }
        public PowerSterringOilResponse GetAllOils()
        {
            var powerSterringOilResponseList = db.PowerSterringOils.ToList();
            return new PowerSterringOilResponse
            {
                PowerSterringOils = powerSterringOilResponseList,
                TotalCount = powerSterringOilResponseList.Count
            };
        }

        public PowerSterringOil GetPowerSterringOilById(int id)
        {
            if (id > 0)
            {
                return DbSet.Find(id);
            }
            return null;
        }
    }
}
