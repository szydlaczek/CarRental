using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Core.Repositories;
using CarRental.Infrastructure.Command;
using CarRental.Infrastructure.Command.CarReservation;

namespace CarRental.Infrastructure.Services.CarReservation
{
    public class CarReservationDbValidator : CarReservation
    {
        private readonly ICarReservationRepository _repository;
        public CarReservationDbValidator(ICarReservationRepository repository)
        {
            _repository = repository;
        }
        public override async Task<CommandResult> Process(CreateCarReservation createCarReservation)
        {
            
            if (_nextHandler != null)
               return await  _nextHandler.Process(createCarReservation);
            else
                return new CommandResult();
        }
    }
}
