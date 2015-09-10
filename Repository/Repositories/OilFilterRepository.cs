using System.Data.Entity;
using System.Linq;
using Interfaces.Repository;
using Microsoft.Practices.Unity;
using Models.DomainModels;
using Models.ResponseModels;
using Repository.BaseRepository;

namespace Repository.Repositories
{
    public class OilFilterRepository : BaseRepository<OilFilter>, IOilFilterRepository
    {
        public OilFilterRepository(IUnityContainer container) : base(container)
        {
        }

        protected override IDbSet<OilFilter> DbSet
        {
            get { return db.OilFilters; }
        }
    }
}
