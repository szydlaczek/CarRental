using CarRental.Infrastructure.Command;
using CarRental.Infrastructure.Command.CarReservation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Services.CarReservation
{
    
    public abstract class CarReservation
    {
        protected CarReservation _nextHandler;
        public void SetNextOperation(CarReservation nextOperation)
        {
            _nextHandler = nextOperation;
        }
        public abstract Task<CommandResult> Process(CreateCarReservation createCarReservation);
    }
}
