using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private readonly HashSet<CarReservation> carReservations = new HashSet<CarReservation>();
        public IEnumerable<CarReservation> CarReservations
        {
            get
            {
                return this.carReservations;
            }
        }

        protected CarType() {  }
        public CarType(string name, int capacity, int passengerCount, int numberOfCars, decimal dayPrice)
        {
            Name = name;
            Capacity = capacity;
            passengerCount = PassengerCount;
            NumberOfCars = numberOfCars;
        }
        public CreateCarReservationResult AddReservation(CarReservation carReservation)
        {
            var reservationsPerDay = this.carReservations
                .Where(c => c.ReservationDate.Date == carReservation.ReservationDate.Date && c.CarType.Id==this.Id)
                .Count(); ;
            if (reservationsPerDay < this.NumberOfCars)
            {
                carReservations.Add(carReservation);
                return CreateCarReservationResult.Success;
            }
            else
                return CreateCarReservationResult.MaxCarPerDayExExceeded;   
        }
    }
}
