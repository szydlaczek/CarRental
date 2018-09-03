using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;

namespace CarRental.Core.Domain
{
    [Table(name: "CarType")]
    public class CarTypeEntity
    {
        [Key]
        public int Id { get; private set; }
        [Required]
        public string Name { get; private set; }
        [Required]
        public int Capacity { get; private set; }
        [Required]
        public int PassengerCount { get; private set; }
        [Required]
        public int NumberOfCars { get; private set; }
        [Required]
        public decimal DayPrice { get; private set; }
        protected virtual ICollection<CarReservationEntity> CarReservationStorage { get; set; }
        public static Expression<Func<CarTypeEntity, ICollection<CarReservationEntity>>> CarReservationeAccessor = f => f.CarReservationStorage;

        public IEnumerable<CarReservationEntity> CarReservations
        {
            get
            {
                return this.CarReservationStorage.Skip(0);
            }
        }

        protected CarTypeEntity()
        {
            CarReservationStorage = new HashSet<CarReservationEntity>();
        }

        public CarTypeEntity(string name, int capacity, int passengerCount, int numberOfCars, decimal dayPrice)
        {
            Name = name;
            Capacity = capacity;
            passengerCount = PassengerCount;
            NumberOfCars = numberOfCars;

        }

        public CreateCarReservationResult AddCarReservation(CarReservationEntity reservation)
        {
            if (this.CarReservationStorage == null)
                this.CarReservationStorage = new HashSet<CarReservationEntity>();
            var reservationCount = this.CarReservationStorage.Where(c => c.ReservationDate.Date == reservation.ReservationDate.Date).Count();
            if (reservationCount < this.NumberOfCars)
            {
                CarReservationStorage.Add(reservation);
                return CreateCarReservationResult.Success;
            }
            else
                return CreateCarReservationResult.MaxCarPerDayExceeded;
        }
    }
}