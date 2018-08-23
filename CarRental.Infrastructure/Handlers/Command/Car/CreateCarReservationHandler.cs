using CarRental.Infrastructure.Command;
using CarRental.Infrastructure.Command.CarReservation;
using CarRental.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Handlers.Car
{
    public class CreateCarReservationHandler : ICommandHandler<CreateCarReservation>
    {
        private readonly ICarReservationService _carReservationService;
        public CreateCarReservationHandler(ICarReservationService carReservationService)
        {
            _carReservationService = carReservationService;
        }
        public async Task HandleAsync(CreateCarReservation Command)
        {
            _carReservationService.GetType();
        }
    }
}
