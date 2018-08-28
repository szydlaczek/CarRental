using CarRental.Infrastructure.Validation;
using System;
//using System.ComponentModel.DataAnnotations;
using FluentValidation;
using FluentValidation.Attributes;
using System.ComponentModel.DataAnnotations;

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
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime ReservationDate { get; set; } = DateTime.Now;
    }
}