using System;

namespace CarRental.Infrastructure.Command.CarReservation
{
    public class CreateCarReservation : ICommand
    {
        public int CarTypeId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Street { get; set; }
        public DateTime ReservationDate { get; set; } = DateTime.Now;
    }
}