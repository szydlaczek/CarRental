using CarRental.Core.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarRental.Core.Repositories
{
    public interface ICarTypeRepository : IRepository
    {
        Task<CarTypeEntity> GetCarTypeById(int id);
        Task<List<CarTypeEntity>> GetAllCarTypes();
    }
}