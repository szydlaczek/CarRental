using CarRental.Core.Domain;
using CarRental.Infrastructure.EFDbContext;
using System.Data.Entity;

namespace CarRental.Infrastructure.ApplicationDbContext
{
    public class ApplicationContext : DbContext, IDbContext
    {
        public IDbSet<CarReservationEntity> CarReservation { get; set; }
        public IDbSet<CarTypeEntity> CarType { get; set; }

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