using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Infrastructure.Command;
using CarRental.Infrastructure.Command.CarReservation;

namespace CarRental.Infrastructure.Services.CarReservation
{
    public class CarReservationProcessor : CarReservation
    {
        public override Task<CommandResult> Process(CreateCarReservation createCarReservation)
        {
            throw new NotImplementedException();
        }
    }
}
