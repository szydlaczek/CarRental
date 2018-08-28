using System;
using System.ComponentModel.DataAnnotations;

namespace CarRental.Infrastructure.Command.CarReservation
{
    public class CreateCarReservation : ICommand
    {
        public int CarTypeId { get; set; }
        [Required]
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Street { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime ReservationDate { get; set; } = DateTime.Now;
    }
}