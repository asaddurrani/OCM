using System.Data.Entity;
using System.Linq;
using Interfaces.Repository;
using Microsoft.Practices.Unity;
using Models.DomainModels;
using Models.ResponseModels;
using Repository.BaseRepository;

namespace Repository.Repositories
{
    public class OilChangeRecordRepository : BaseRepository<OilChangeRecord>, IOilChangeRecordRepository
    {
        public OilChangeRecordRepository(IUnityContainer container) : base(container)
        {
        }

        protected override IDbSet<OilChangeRecord> DbSet
        {
            get { return db.OilChangeRecords; }
        }
    }
}
