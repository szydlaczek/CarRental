using CarRental.Core.Domain;
using CarRental.Infrastructure.Command;
using CarRental.Infrastructure.Command.CarReservation;
using CarRental.Infrastructure.Services;

using CarRental.Infrastructure.Services.CarReservation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Handlers.Car
{
    public class CreateCarReservationHandler : ICommandHandler<CreateCarReservation>
    {
        
        public CreateCarReservationHandler()
        {
            
        }
        public async Task<CommandResult> HandleAsync(CreateCarReservation Command)
        {          


        }
    }
}
