using CarRental.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Core.Specifications.CarType
{
    public class CarTypeSpecificationById : ISpecification<CarTypeEntity>
    {
        public CarTypeSpecificationById(int id)
        {
            Condition = c => c.CarTypeId == id;
        }        
        public Expression<Func<CarTypeEntity, bool>> Condition { get; }
    }
}
