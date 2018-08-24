using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Core.Domain
{
    public class CarReservation : Entity<long>
    {
        public DateTime ReservationDate { get; private set; }

        public long Id { get; private set; }

        public virtual CarType CarType { get; private set; }
    }
}
