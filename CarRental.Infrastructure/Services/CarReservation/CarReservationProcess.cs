using CarRental.Core.Domain;

using CarRental.Core.Specifications.CarType;
using CarRental.Infrastructure.Command;
using CarRental.Infrastructure.EFDbContext;

using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Services.CarReservation
{
    public class CarReservationProcess : ICarReservationProcess
    {
        private readonly IDbContext _context;

        public CarReservationProcess(IDbContext context)
        {
            _context = context;
        }

        public async Task<CommandResult> MakeReservation(CarReservationEntity carReservation)
        {
            var carType = await _context.CarType
                .Where(ct=>ct.Id== carReservation.CarTypeId)
                .FirstOrDefaultAsync();

            if (carType == null)
                return new CommandResult
                {
                    Success = false,
                    Message = "Brak typu pojazdu"
                };
            //var carReservation = new CarReservationEntity(carTypeId, city, postCode, street, phoneNumber, name, dateReservation);
            var result = carType.AddCarReservation(carReservation);

            if (result == CreateCarReservationResult.MaxCarPerDayExceeded)
                return new CommandResult
                {
                    Success = false,
                    Message = $"Typ pojazdu niedostępny w dniu {carReservation.ReservationDate.ToString("yyyy-MM-dd")} "
                };
            else
            {
                await _context.SaveChangesAsync();
                return new CommandResult
                {
                    Success = true,
                    Message = $"Rezerwacja zakończona, dziękujemy"
                };
            }
        }
    }
}