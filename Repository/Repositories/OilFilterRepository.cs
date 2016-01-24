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
    public class OilFilterRepository : BaseRepository<OilFilter>, IOilFilterRepository
    {
        public OilFilterRepository(IUnityContainer container) : base(container)
        {
        }

        protected override IDbSet<OilFilter> DbSet
        {
            get { return db.OilFilters; }
        }
        public OilFilterResponse GetAllOilFilters()
        {
            var oilFiltersList = db.OilFilters.ToList();
            return new OilFilterResponse
            {
                OilFilters = oilFiltersList,
                TotalCount = oilFiltersList.Count
            };
        }

        public OilFilter GetOilFilterById(int id)
        {
            if (id > 0)
            {
                return DbSet.Find(id);
            }
            return null;
        }
        public OilFilter Save(OilFilter oilFilter)
        {
            if (oilFilter.OilFilterId > 0)
            {
                #region Update Record
                OilFilter oilFilterDbVersion = GetOilFilterById(oilFilter.OilFilterId);
                oilFilterDbVersion.OilFilterName = oilFilter.OilFilterName;
                oilFilterDbVersion.OilFilterPrice = oilFilter.OilFilterPrice;
                oilFilterDbVersion.OilFilterMakerCompanyId = oilFilter.OilFilterMakerCompanyId;
                
                DbSet.AddOrUpdate(oilFilterDbVersion);
                db.SaveChanges();

                #endregion
            }
            else
            {
                #region Add New Record

                DbSet.Add(oilFilter);
                db.SaveChanges();

                #endregion
            }
            return GetOilFilterById(oilFilter.OilFilterId);
        }
    }
}
