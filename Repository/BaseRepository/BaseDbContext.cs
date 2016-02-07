

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Practices.Unity;
using Models.DomainModels;

namespace Repository.BaseRepository
{

    public sealed class BaseDbContext : IdentityDbContext<Models.IdentityModels.ApplicationUsers>
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
        public DbSet<Models.DomainModels.Product> Products { get; set; }
        public DbSet<Models.DomainModels.VehicleMaker> VehicleMakers { get; set; }
        public DbSet<Models.DomainModels.VehicleModelMaker> VehicleModelMakers { get; set; }
        public DbSet<Models.DomainModels.Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerVehicle> CustomerVehicles { get; set; }
        public DbSet<OilChangeRecord> OilChangeRecords { get; set; }
        public DbSet<Models.DomainModels.OilMakerCompany> OilMakerCompanies { get; set; }
        public DbSet<Models.DomainModels.Oil> Oils { get; set; }
        public DbSet<Models.DomainModels.OilNetWeight> OilNetWeights { get; set; }        
        public DbSet<Models.DomainModels.OilFilter> OilFilters { get; set; }        
        public DbSet<Models.DomainModels.AirFilter> AirFilters { get; set; }        
        public DbSet<Models.DomainModels.BrakeOil> BrakeOils { get; set; }        
        public DbSet<Models.DomainModels.PowerSterringOil> PowerSterringOils { get; set; }        
        public DbSet<Models.DomainModels.OilFilterMakerCompany> OilFilterMakerCompanies { get; set; }        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Product>().HasKey(p => p.Id);
            modelBuilder.Entity<Product>().Property(c => c.Id)
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
