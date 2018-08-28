using CarRental.Core.Domain;
using System;
using System.Linq.Expressions;

namespace CarRental.Core.Specifications.CarType
{
    public class CarTypeSpecificationById : ISpecification<CarTypeEntity>
    {
        public CarTypeSpecificationById(int id)
        {
            Condition = c => c.Id == id;
        }

        public Expression<Func<CarTypeEntity, bool>> Condition { get; }
    }
}