using System;
using System.Data.Entity;
using System.Linq;
using Interfaces.Repository;
using Microsoft.Practices.Unity;
using Models.DomainModels;
using Models.ResponseModels;
using Repository.BaseRepository;

namespace Repository.Repositories
{
    public class OilFilterMakerRepository : BaseRepository<OilFilterMakerCompany>, IOilFilterMakerRepository
    {
        public OilFilterMakerRepository(IUnityContainer container)
            : base(container)
        {
        }

        protected override IDbSet<OilFilterMakerCompany> DbSet
        {
            get { return db.OilFilterMakerCompanies; }
        }

        public OilFilterMakerResponse GetAllOilFilterMakerCompanies()
        {
            var oilFilterMakerCompaniesList = db.OilFilterMakerCompanies.ToList();
            return new OilFilterMakerResponse
            {
                OilFilterMakerCompanies = oilFilterMakerCompaniesList,
                TotalCount = oilFilterMakerCompaniesList.Count
            };
        }

        public OilFilterMakerCompany GetOilFilterMakerCompanyById(int id)
        {
            if (id > 0)
            {
                return DbSet.Include("OilFilterMakerCompany").FirstOrDefault(x => x.OilFilterMakerCompanyId == id);
            }
            return null;
        }

        public OilFilterMakerCompany Save(OilFilterMakerCompany oil)
        {
            throw new NotImplementedException();
        }
    }
}
