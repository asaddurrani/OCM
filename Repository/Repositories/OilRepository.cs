using System.Data.Entity;
using System.Data.Entity.Migrations;
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
                return DbSet.Include("OilMakerCompany").FirstOrDefault(x => x.OilId == id);
            }
            return null;
        }

        public Oil Save(Oil oil)
        {
            if (oil.OilId > 0)
            {
                #region Update Record
                Oil oilDbVersion = GetOilById(oil.OilId);
                oilDbVersion.OilName = oil.OilName;
                oilDbVersion.OilMakerId = oil.OilMakerId;
                oilDbVersion.OilAverageMilage = oil.OilAverageMilage;
                oilDbVersion.OilPower = oil.OilPower;
                oilDbVersion.OilPrice = oil.OilPrice;
                oilDbVersion.OilDescription = oil.OilDescription;
                oilDbVersion.OilNetWeightId = oil.OilNetWeightId;
                DbSet.AddOrUpdate(oilDbVersion);
                db.SaveChanges();

                #endregion
            }
            else
            {
                #region Add New Record

                DbSet.Add(oil);
                db.SaveChanges();

                #endregion
            }
            return GetOilById(oil.OilId);
        }
    }
}
