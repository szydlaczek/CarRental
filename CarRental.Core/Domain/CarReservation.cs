using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Core.Domain
{
    [Table(name: "CarReservation")]
    public class CarReservationEntity
    {
        [Required]
        public DateTime ReservationDate { get; private set; }
        public long Id { get; private set; }
        [Required]
        public string Name { get; private set; }
        [Required]
        public string PhoneNumber { get; private set; }
        [Required]
        public string City { get; private set; }
        [Required]
        public string PostCode { get; private set; }
        [Required]
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
            CarTypeId = carTypeId;
        }

        protected CarReservationEntity()
        {
        }
    }
}