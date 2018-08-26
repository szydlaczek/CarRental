using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CarRental.Core.Domain;

namespace CarRental.Infrastructure.ApplicationDbContext
{
    public class ApplicationContext : DbContext
    {
        public IDbSet<CarReservationEntity> CarReservation { get; set; }
        public IDbSet<CarTypeEntity> CarType { get; set; }
        public ApplicationContext():base("CarRental")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CarTypeEntity>().HasMany(CarRental.Core.Domain.CarTypeEntity.CarReservationeAccessor)
                .WithRequired();

        }
    }
}
