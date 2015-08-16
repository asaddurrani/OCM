using System.Data.Entity;
using System.Linq;
using Interfaces.Repository;
using Microsoft.Practices.Unity;
using Models.DomainModels;
using Models.ResponseModels;
using Repository.BaseRepository;

namespace Repository.Repositories
{
    public class OilRepository : BaseRepository<Oil>, IOilRepository
    {
        public OilRepository(IUnityContainer container) : base(container)
        {
        }

        protected override IDbSet<Oil> DbSet
        {
            get { return db.Oils; }
        }
    }
}
