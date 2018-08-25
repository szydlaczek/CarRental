using CarRental.Core.Domain;
using System;
using System.Linq.Expressions;

namespace CarRental.Core.Specifications.CarReservationSpecifications
{
    public class DateSpecification : ISpecification<CarReservation>
    {

        public DateSpecification(int id, DateTime date)
        {

        }

        public Expression<Func<CarReservation, bool>> IsSatisfiedBy { get; }
    }
}
