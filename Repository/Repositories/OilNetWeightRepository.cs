using System.Data.Entity;
using System.Linq;
using Interfaces.Repository;
using Microsoft.Practices.Unity;
using Models.DomainModels;
using Models.ResponseModels;
using Repository.BaseRepository;

namespace Repository.Repositories
{
    public class OilNetWeightRepository : BaseRepository<OilNetWeight>, IOilNetWeightRepository
    {
        public OilNetWeightRepository(IUnityContainer container) : base(container)
        {
        }

        protected override IDbSet<OilNetWeight> DbSet
        {
            get { return db.OilNetWeights; }
        }
    }
}
