using GeziRehberi.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeziRehberi.DAL.Concrete.EntityFramework
{
    public class GeziDbContext:DbContext
    {
        public GeziDbContext():base("Server=.;Database=GeziRehberiDB;Integrated Security=true;")
        {
            //Database.SetInitializer<GeziDbContext>(new Strategy());
            
            //Database.Initialize(true);
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Continent> Continent { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Otel> Otels { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<VisitingPlaces> VisitingPlaces { get; set; }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modellerimin içindeki propertylerden tip olarak datetime kullanan varsa, sql tarafında karşılığını bulamaz diye tipini çevirme işlemi yapıyoruz.modelle ilgili değişiklik yaptığımız içinde bunu OnModelCreating metodunu override ederek yazıyoruz.
            modelBuilder.Properties().Where(a => a.PropertyType == typeof(DateTime)).Configure(a => a.HasColumnType("datetime2"));
        }

    }
}
