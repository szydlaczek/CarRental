using CarRental.Core.Domain;
using System;
using System.Linq.Expressions;

namespace CarRental.Core.Specifications.CarReservationSpecifications
{
    public class DateSpecification : ISpecification<CarReservationEntity>
    {
        public DateSpecification(int id, DateTime date)
        {
        }

        public Expression<Func<CarReservationEntity, bool>> IsSatisfiedBy { get; }
    }
}