using CarRental.Infrastructure.Command;
using CarRental.Infrastructure.Command.CarReservation;

using CarRental.Infrastructure.Services.CarReservation;
using System;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Handlers.Car
{
    public class CreateCarReservationHandler : ICommandHandler<CreateCarReservation>
    {
        private readonly ICarReservationProcess _carReservationProcess;

        public CreateCarReservationHandler(ICarReservationProcess carReservationProcess)
        {
            _carReservationProcess = carReservationProcess;
        }

        public async Task<CommandResult> HandleAsync(CreateCarReservation command)
        {
            CommandResult result = await _carReservationProcess.MakeReservation(command.CarTypeId, command.Name,
                command.PhoneNumber, command.PostCode, command.City, command.Street, command.GetReservationDate());
            return result;
        }
    }
}