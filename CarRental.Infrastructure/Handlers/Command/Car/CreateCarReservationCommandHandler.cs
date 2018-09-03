using CarRental.Core.Domain;
using CarRental.Infrastructure.Command;
using CarRental.Infrastructure.Command.CarReservation;

using CarRental.Infrastructure.Services.CarReservation;
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
            CarReservationEntity carReservation = new CarReservationEntity(command.CarTypeId, command.City,
                command.PostCode, command.Street, 
                command.PhoneNumber, command.Name, 
                command.GetReservationDate());

            CommandResult result = await _carReservationProcess.MakeReservation(carReservation);
            return result;
        }
    }
}