using CarRental.Core.Domain;
using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.EFDbContext
{
    public interface IDbContext : IDisposable
    {
        IDbSet<CarTypeEntity> CarType { get; set; }
        IDbSet<CarReservationEntity> CarReservation { get; set; }
        Task<int> SaveChangesAsync();
    }
}