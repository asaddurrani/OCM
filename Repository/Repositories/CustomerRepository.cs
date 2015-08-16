using System.Data.Entity;
using System.Linq;
using Interfaces.Repository;
using Microsoft.Practices.Unity;
using Models.DomainModels;
using Models.ResponseModels;
using Repository.BaseRepository;


namespace Repository.Repositories
{
    public sealed class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(IUnityContainer container) : base(container)
        {
        }

        protected override IDbSet<Customer> DbSet
        {
            get { return db.Customers; }
        }
    }
}
