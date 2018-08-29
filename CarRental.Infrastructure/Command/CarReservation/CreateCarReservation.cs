using CarRental.Infrastructure.Validation;

//using System.ComponentModel.DataAnnotations;
using FluentValidation.Attributes;
using System;
using System.Globalization;

namespace CarRental.Infrastructure.Command.CarReservation
{
    [Validator(typeof(CarReservationValidator))]
    public class CreateCarReservation : ICommand
    {
        public int CarTypeId { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string City { get; set; }

        public string PostCode { get; set; }

        public string Street { get; set; }

        public string ReservationDate { get; set; }

        public DateTime GetReservationDate()
        {
            DateTime date;
            DateTime.TryParseExact(this.ReservationDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out date);
            return date;
        }
    }
}