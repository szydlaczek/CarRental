using CarRental.Core.Domain;
using CarRental.Infrastructure.EFDbContext;
using System.Data.Entity;

namespace CarRental.Infrastructure.ApplicationDbContext
{
    public class ApplicationContext : DbContext, IDbContext
    {
        public DbSet<CarReservationEntity> CarReservation { get; set; }
        public DbSet<CarTypeEntity> CarType { get; set; }
        public ApplicationContext() : base("CarRental")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CarTypeEntity>().HasMany(CarTypeEntity.CarReservationeAccessor)
                .WithRequired();
        }

        
    }
}