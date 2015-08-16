using System.Data.Entity;
using System.Linq;
using Interfaces.Repository;
using Microsoft.Practices.Unity;
using Models.DomainModels;
using Models.RequestModels;
using Models.ResponseModels;
using Repository.BaseRepository;

namespace Repository.Repositories
{
    public sealed class VehicleModelMakerRepository : BaseRepository<VehicleModelMaker>, IVehicleModelMakerRepository
    {
        public VehicleModelMakerRepository(IUnityContainer container) : base(container)
        {
        }

        protected override IDbSet<VehicleModelMaker> DbSet
        {
            get
            {
                return db.VehicleModelMakers;
            }
        }


        public VehicleModelMakerResponse GetAllVehicles(VehicleModelMakerSearchRequest vehicleModelMakerSearchRequest)
        {
            var vehicalModelMakersList = db.VehicleModelMakers.ToList();
            return new VehicleModelMakerResponse
            {
                VehicleModelMakers = vehicalModelMakersList,
                TotalCount = vehicalModelMakersList.Count
            };
        }

        public VehicleModelMaker GetVehicleById(int id)
        {
            if (id > 0)
            {
                return DbSet.Find(id);
            }
            return null;
        }
    }
}
