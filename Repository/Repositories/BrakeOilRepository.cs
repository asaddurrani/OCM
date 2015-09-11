using System.Data.Entity;
using System.Linq;
using Interfaces.Repository;
using Microsoft.Practices.Unity;
using Models.DomainModels;
using Models.ResponseModels;
using Repository.BaseRepository;


namespace Repository.Repositories
{
    public class BrakeOilRepository : BaseRepository<BrakeOil>, IBrakeOilRepository
    {
        public BrakeOilRepository(IUnityContainer container) : base(container)
        {
        }

        protected override IDbSet<BrakeOil> DbSet
        {
            get { return db.BrakeOils; }
        }
        public BrakeOilResponse GetAllBrakeOils()
        {
            var brakeOilsList = db.BrakeOils.ToList();
            return new BrakeOilResponse
            {
                BrakeOils = brakeOilsList,
                TotalCount = brakeOilsList.Count
            };
        }

        public BrakeOil GetBrakeOilById(int id)
        {
            if (id > 0)
            {
                return DbSet.Find(id);
            }
            return null;
        }
    }
}
