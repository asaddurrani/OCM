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


        public OilResponse GetAllOils()
        {
            var oilsList = db.Oils.ToList();
            return new OilResponse
            {
                Oils = oilsList,
                TotalCount = oilsList.Count
            };
        }

        public Oil GetOilById(int id)
        {
            if (id > 0)
            {
                return DbSet.Find(id);
            }
            return null;
        }
    }
}
