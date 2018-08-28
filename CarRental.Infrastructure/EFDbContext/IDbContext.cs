using CarRental.Core.Domain;
using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.EFDbContext
{
    public interface IDbContext : IDisposable
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class; 
        Task<int> SaveChangesAsync();
    }
}