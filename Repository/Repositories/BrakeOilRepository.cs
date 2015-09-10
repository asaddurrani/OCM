using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Repository;
using Microsoft.Practices.Unity;
using Models.DomainModels;
using Repository.BaseRepository;

namespace Repository.Repositories
{
    public class BrakeOilRepository : BaseRepository<BrakeOil>, IBrakeOilRepository
    {
        public BrakeOilRepository(IUnityContainer container) : base(container)
        {
        }

        protected override IDbSet<BrakeOil> DbSet
        {
            get { return db.BrakeOils; }
        }
    }
}
