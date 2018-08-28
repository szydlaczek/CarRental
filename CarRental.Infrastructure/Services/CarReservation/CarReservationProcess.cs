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

        public async Task<CommandResult> MakeReservation(int carTypeId, string name,
            string phoneNumber, string postCode,
            string city, string street,
            DateTime dateReservation)
        {
            var carType = await _context.Set<CarTypeEntity>().Where(new CarTypeSpecificationById(carTypeId).Condition).FirstOrDefaultAsync();
            if (carType == null)
                return new CommandResult
                {
                    Success = false,
                    Message = "Car Type doesnt exists"
                };
            var carReservation = new CarReservationEntity(carTypeId, city, postCode, street, phoneNumber, name);
            var result = carType.AddCarReservation(carReservation);

            if (result == CreateCarReservationResult.MaxCarPerDayExceeded)
                return new CommandResult
                {
                    Success = false,
                    Message = $"Typ pojazdu niedostępny w dniu {dateReservation.Date} "
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