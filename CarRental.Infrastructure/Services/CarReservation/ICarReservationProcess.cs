using CarRental.Infrastructure.Command;
using System;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Services.CarReservation
{
    public interface ICarReservationProcess : IService
    {
        Task<CommandResult> MakeReservation(int carTypeId, string name,
            string phoneNumber, string postCode,
            string city, string street,
            DateTime dateReservation);
    }
}