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
        public IDbSet<CarReservation> CarReservation { get; set; }
        public IDbSet<CarType> CarType { get; set; }
        public ApplicationContext():base("")
        {

        }
        public override Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }
    }
}
