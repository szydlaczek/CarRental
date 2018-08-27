using CarRental.Core.Domain;
using CarRental.Core.Specifications;
using System.Collections.Generic;

namespace CarRental.Core.Repositories
{
    public interface ICarReservationRepository : IRepository
    {
        IEnumerable<CarTypeEntity> Get(ISpecification<CarReservationEntity> specification);
    }
}