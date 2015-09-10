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
    }
}
