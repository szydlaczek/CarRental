using CarRental.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CarRental.Infrastructure.EFDbContext
{
    public interface IDbContext : IDisposable
    {
        IDbSet<CarReservationEntity> CarReservation { get; set; }
        IDbSet<CarTypeEntity> CarType { get; set; }
        int SaveChanges();
        Task<int> SaveChangesAsync();

    }
}
