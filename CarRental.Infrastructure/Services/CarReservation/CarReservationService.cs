using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Infrastructure.Command;
using CarRental.Infrastructure.Command.CarReservation;

namespace CarRental.Infrastructure.Services.CarReservation
{
    public class CarReservationService : ICarReservationService
    {
        public readonly CarReservationCreator _creator;
        public CarReservationService(CarReservationCreator creator)
        {
            _creator = creator;
        }       

        public Task<CommandResult> AddCarReservation(CreateCarReservation command)
        {
            return _creator.Process(command);
        }
    }
}
