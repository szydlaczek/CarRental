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
        public readonly ICarReservationService _carReservation;
        public CreateCarReservationHandler(ICarReservationService carReservation)
        {
            _carReservation = carReservation;
        }
        public async Task<CommandResult> HandleAsync(CreateCarReservation Command)
        {
            return await _carReservation.AddCarReservation(Command);
            
        }
    }
}
