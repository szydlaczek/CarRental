using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CarRental.Core.Domain
{
    public class CarType : Entity<int>
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Capacity { get; private set; }
        public int PassengerCount { get; private set; }
        public int NumberOfCars { get; private set; }
        public decimal DayPrice { get; private set; }
        protected virtual ICollection<CarReservation> CarReservationStorage { get; set; }
        public static Expression<Func<CarType, ICollection<CarReservation>>> CarReservationeAccessor = f => f.CarReservationStorage;

        public IEnumerable<CarReservation> CarReservations
        {
            get
            {
                return this.CarReservationStorage.Skip(0);
            }
        }

        protected CarType()
        {
        }

        public CarType(string name, int capacity, int passengerCount, int numberOfCars, decimal dayPrice)
        {
            Name = name;
            Capacity = capacity;
            passengerCount = PassengerCount;
            NumberOfCars = numberOfCars;
        }
    }
}