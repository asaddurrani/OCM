using System.Data.Entity;
using System.Linq;
using Interfaces.Repository;
using Microsoft.Practices.Unity;
using Models.DomainModels;
using Models.ResponseModels;
using Repository.BaseRepository;
namespace Repository.Repositories
{
    public class CustomerVehicleRepository : BaseRepository<CustomerVehicle>, ICustomerVehicleRepository
    {
        public CustomerVehicleRepository(IUnityContainer container) : base(container)
        {
        }

        protected override IDbSet<CustomerVehicle> DbSet
        {
            get {return db.CustomerVehicles; }
        }
    }
}
