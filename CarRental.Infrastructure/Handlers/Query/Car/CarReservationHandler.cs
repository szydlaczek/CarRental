using CarRental.Infrastructure.Command.CarReservation;
using CarRental.Infrastructure.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Handlers.Query.Car
{
    public class CarReservationHandler : IQueryHandler<CreateCarReservation>
    {
        public Task<CreateCarReservation> Retrieve()
        {
            return null;
        }
        
    }
    public class EditCarReservationHandler : IQueryHandler<CreateCarReservation, CreateCarReservation>
    {       

        public Task<CreateCarReservation> Retrieve(CreateCarReservation query)
        {
            throw new NotImplementedException();
        }
    }
}
