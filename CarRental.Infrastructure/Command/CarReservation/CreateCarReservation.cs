using CarRental.Infrastructure.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Command.CarReservation
{
    public class CreateCarReservation : ICommand
    {
        public int CarTypeId { get; set; }        
        public string Name { get;  set; }
        public string PhoneNumber { get;  set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Street { get; set; }
        public DateTime ReservationDate { get; set; }
    }
}
