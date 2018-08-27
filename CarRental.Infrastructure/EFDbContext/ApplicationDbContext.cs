using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CarRental.Core.Domain;
using CarRental.Infrastructure.EFDbContext;

namespace CarRental.Infrastructure.ApplicationDbContext
{
    public class ApplicationContext : DbContext, IDbContext
    {
        public IDbSet<CarReservationEntity> CarReservation { get; set; }
        public IDbSet<CarTypeEntity> CarType { get; set; }
        public ApplicationContext():base("CarRental")
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
