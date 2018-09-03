using CarRental.Core.Domain;
using CarRental.Infrastructure.Command;
using System;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Services.CarReservation
{
    public interface ICarReservationProcess : IService
    {
        Task<CommandResult> MakeReservation(CarReservationEntity carReservation);
    }
}