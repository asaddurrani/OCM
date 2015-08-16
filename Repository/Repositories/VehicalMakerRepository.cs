using System.Data.Entity;
using System.Linq;
using Interfaces.Repository;
using Microsoft.Practices.Unity;
using Models.DomainModels;
using Models.ResponseModels;
using Repository.BaseRepository;

namespace Repository.Repositories
{
    public sealed class VehicalMakerRepository : BaseRepository<Models.DomainModels.VehicleMaker>, IVehicleMakerRepository
    {
        public VehicalMakerRepository(IUnityContainer container) : base(container)
        {
        }

        protected override IDbSet<Models.DomainModels.VehicleMaker> DbSet
        {
            get
            {
                return db.VehicleMakers;
            }
        }

        public VehicalMakerResponse GetAllVehicleMakers()
        {
            var vehicalMakersList = db.VehicleMakers.ToList();
            return new VehicalMakerResponse
            {
                VehicleMakers = vehicalMakersList,
                TotalCount = vehicalMakersList.Count
            };
        }

        public VehicleMaker GetVehicleById(int id)
        {
            if (id > 0)
            {
                return DbSet.Find(id);
            }
            return null;
        }
    }
}
