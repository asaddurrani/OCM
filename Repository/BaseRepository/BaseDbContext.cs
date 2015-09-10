using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Interfaces.Repository;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Practices.Unity;
using Models.DomainModels;
using Models.IdentityModels;

namespace Repository.BaseRepository
{

    public sealed class BaseDbContext : IdentityDbContext<ApplicationUser>
    {
        private IUnityContainer container;
        public BaseDbContext(string connectionString,IUnityContainer container)
            : base(connectionString)
        {
            this.container = container;
        }

        //public IApplicationEntities Entities
        //{
        //    get
        //    {
        //        return container.Resolve<IApplicationEntities>();
        //    }
        //}
        public DbSet<Models.DomainModels.Products> Products { get; set; }
        public DbSet<Models.DomainModels.VehicleMaker> VehicleMakers { get; set; }
        public DbSet<Models.DomainModels.VehicleModelMaker> VehicleModelMakers { get; set; }
        public DbSet<Models.DomainModels.Category> Categories { get; set; }
        public DbSet<Models.DomainModels.Customer> Customers { get; set; }
        public DbSet<Models.DomainModels.CustomerVehicle> CustomerVehicles { get; set; }
        public DbSet<Models.DomainModels.OilChangeRecord> OilChangeRecords { get; set; }
        public DbSet<Models.DomainModels.OilMakerCompany> OilMakerCompanies { get; set; }
        public DbSet<Models.DomainModels.Oil> Oils { get; set; }
        public DbSet<Models.DomainModels.OilNetWeight> OilNetWeights { get; set; }        
        public DbSet<Models.DomainModels.OilFilter> OilFilters { get; set; }        
        public DbSet<Models.DomainModels.AirFilter> AirFilters { get; set; }        
        public DbSet<Models.DomainModels.BrakeOil> BrakeOils { get; set; }        
        public DbSet<Models.DomainModels.PowerSterringOil> PowerSterringOils { get; set; }        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Products>().HasKey(p => p.Id);
            modelBuilder.Entity<Products>().Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
    //public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    //{
    //    public ApplicationDbContext()
    //        : base("DefaultConnection")
    //    {
    //    }
    //    public DbSet<Category> Categories { get; set; }

    //    public DbSet<Product> Products { get; set; }


    //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //    {
    //        // Configure Code First to ignore PluralizingTableName convention 
    //        // If you keep this convention, the generated tables  
    //        // will have pluralized names. 
    //        base.OnModelCreating(modelBuilder);
    //        modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    //        modelBuilder.Entity<Product>().HasKey(p => p.Id);
    //        modelBuilder.Entity<Product>().Property(c => c.Id)
    //            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);  
    //    } 
    //}
}
