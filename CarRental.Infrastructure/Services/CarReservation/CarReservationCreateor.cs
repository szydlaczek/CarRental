using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Infrastructure.Command;
using CarRental.Infrastructure.Command.CarReservation;

namespace CarRental.Infrastructure.Services.CarReservation
{
    public class CarReservationCreator : CarReservation
    {

        public CarReservationCreator(CarReservationDbValidator carReservationDbValidator, CarReservationCreator carReservationCreateor)
        {
            base._nextHandler = carReservationDbValidator;
            carReservationDbValidator.SetNextOperation(carReservationDbValidator);
        }
        public override Task<CommandResult> Process(CreateCarReservation createCarReservation)
        {
            return _nextHandler.Process(createCarReservation);
        }
    }
}
