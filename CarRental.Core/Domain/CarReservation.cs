using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Core.Domain
{
    [Table(name: "CarReservation")]
    public class CarReservationEntity
    {
        public DateTime ReservationDate { get; private set; }
        public long Id { get; private set; }
        public string Name { get; private set; }
        public string PhoneNumber { get; private set; }
        public string City { get; private set; }
        public string PostCode { get; private set; }
        public string Street { get; private set; }
        public int CarTypeId { get; private set; }
        public CarReservationEntity(int carTypeId, string city,
            string postCode, string street,
            string phoneNumber, string name, DateTime date)
        {
            City = city;
            PostCode = postCode;
            Street = street;
            PhoneNumber = phoneNumber;
            Name = name;
            ReservationDate = date;
        }

        protected CarReservationEntity()
        {
        }
    }
}