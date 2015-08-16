using System.Data.Entity;
using System.Linq;
using Interfaces.Repository;
using Microsoft.Practices.Unity;
using Models.DomainModels;
using Models.ResponseModels;
using Repository.BaseRepository;

namespace Repository.Repositories
{
    public class OilMakerCompanyRepository : BaseRepository<OilMakerCompany>, IOilMakerCompanyRepository
    {
        public OilMakerCompanyRepository(IUnityContainer container) : base(container)
        {
        }

        protected override IDbSet<OilMakerCompany> DbSet
        {
            get { return db.OilMakerCompanies; }
        }
    }
}
