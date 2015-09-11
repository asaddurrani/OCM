using System.Data.Entity;
using System.Linq;
using Interfaces.Repository;
using Microsoft.Practices.Unity;
using Models.DomainModels;
using Models.ResponseModels;
using Repository.BaseRepository;

namespace Repository.Repositories
{
    public class AirFilterRepository : BaseRepository<AirFilter>, IAirFilterRepository
    {
        public AirFilterRepository(IUnityContainer container) : base(container)
        {
        }

        protected override IDbSet<AirFilter> DbSet
        {
            get { return db.AirFilters; }
        }
        public AirFilterResponse GetAllAirFilters()
        {
            var airFiltersList = db.AirFilters.ToList();
            return new AirFilterResponse
            {
                AirFilters = airFiltersList,
                TotalCount = airFiltersList.Count
            };
        }

        public AirFilter GetAirFilterById(int id)
        {
            if (id > 0)
            {
                return DbSet.Find(id);
            }
            return null;
        }
    }
}
