using CarRental.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Core.Specifications.CarReservation
{
    public class DateSpecification : ISpecification<CarType>
    {
        public Expression<Func<CarType, bool>> IsSatisfiedBy { get; }
        public DateSpecification(int id, DateTime date)
        {
            
        }
        
    }
}
