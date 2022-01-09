using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_cf__Apartment_brokerage_.Class
{
    class ApartContext : DbContext
    {
        public DbSet<Apart_ForRent> Aparts_ForRent { get; set; }
        public DbSet<Apart_ForSale> Aparts_ForSale { get; set; }
        public DbSet<Owner_Details> Owner { get; set; }
        public DbSet<Furniture> Furnitures { get; set; }

        public ApartContext() : base("data source=.;initial catalog=ApartmentBrokerage_db;integrated security=True") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) 
        {
            Database.SetInitializer<ApartContext>(new DropCreateDatabaseIfModelChanges<ApartContext>());
            base.OnModelCreating(modelBuilder);
        }

    }
}
