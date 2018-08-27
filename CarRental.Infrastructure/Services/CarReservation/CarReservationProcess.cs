using CarRental.Core.Domain;
using CarRental.Core.Repositories;
using CarRental.Infrastructure.Command;
using CarRental.Infrastructure.Command.CarReservation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Services.CarReservation
{
    public class CarReservationProcess : IService
    {
        private readonly ICarTypeRepository _carTypeRepository;
        
        public CarReservationProcess(ICarTypeRepository carTypeRepository)
        {
            _carTypeRepository = carTypeRepository;
            
        }
        public async Task<CommandResult> MakeReservation(int carTypeId, string name, 
            string phoneNumber, string postCode, 
            string city, string street,
            DateTime dateReservation)
        {
            var carType = await _carTypeRepository.GetCarTypeById(carTypeId);
            if (carType == null)
                return new CommandResult
                {
                    Success = false,
                    Message = "Car Type doesnt exists"
                };
            var carReservation = new CarReservationEntity(carTypeId, city, postCode, street, phoneNumber, name);
            var result=carType.AddCarReservation(carReservation);
            
            if (result == CreateCarReservationResult.MaxCarPerDayExceeded)
                return new CommandResult
                {
                    Success = false,
                    Message = $"Typ pojazdu niedostępny w dniu {dateReservation.Date} "
                };
            else
            {
                return new CommandResult
                {
                    Success = true,
                    Message = $"Rezerwacja zakończona, dziękujemy"
                };
            }

                
        }
    }
}
