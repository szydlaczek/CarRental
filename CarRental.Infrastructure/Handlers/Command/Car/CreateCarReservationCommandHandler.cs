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
        private readonly CarReservationProcess _carReservationProcess;
        public CreateCarReservationHandler(CarReservationProcess carReservationProcess)
        {
            _carReservationProcess = carReservationProcess;
        }
        public async Task<CommandResult> HandleAsync(CreateCarReservation command)
        {
            CommandResult result = await _carReservationProcess.MakeReservation(command.CarTypeId,command.Name,
                command.PhoneNumber, command.PostCode, command.City, command.Street, command.ReservationDate);
            return result;
        }
    }
}
