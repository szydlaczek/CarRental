using CarRental.Infrastructure.Command;
using CarRental.Infrastructure.Command.CarReservation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Services.CarReservation
{
    public interface ICarReservationService : IService
    {
        Task<CommandResult> AddCarReservation(CreateCarReservation command);
       
    }
}
