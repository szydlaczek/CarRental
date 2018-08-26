using CarRental.Core.Domain;

namespace CarRental.Core.Repositories
{
    public interface ICarTypeRepository
    {
        CarTypeEntity GetCarTypeById(int id);
    }
}