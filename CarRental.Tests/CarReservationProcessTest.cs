using CarRental.Core.Domain;
using CarRental.Infrastructure.Command.CarReservation;
using CarRental.Infrastructure.EFDbContext;
using CarRental.Infrastructure.Services.CarReservation;
using Moq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CarRental.Tests
{
    public class CarReservationProcessTest : BaseTest
    {
        CarReservationProcess carReservationProcess;
        public CarReservationProcessTest():base()
        {
            carReservationProcess = new CarReservationProcess(mockcontext.Object);
            
        }
        [Fact]
        public async Task makereservation_should_invoke_savechanges_on_dbcontext()
        {
            var command = new CreateCarReservation
            {
                City = "TestCity",
                PostCode = "57-400",
                Name = "TestName",
                CarTypeId = 0,
                PhoneNumber = "55555555",
                ReservationDate = "2018-08-08",
                Street = "TestStreet"
            };           
            
             
            CarReservationEntity carReservation = new CarReservationEntity(command.CarTypeId, command.City
                , command.PostCode, command.Street, command.PhoneNumber, command.Name, command.GetReservationDate());
            var result= await carReservationProcess.MakeReservation(carReservation);
            mockcontext.Verify(x => x.SaveChangesAsync(), Times.Once);
            Assert.True(result.Success);
        }
        [Fact]
        public async Task makereservation_should_return_false()
        {
            var carType = base.carTypeList.FirstOrDefault();
            carType.AddCarReservation(new CarReservationEntity(0, "Test1", "Test1", "Test1", "Test1", "Test1", DateTime.Now.Date));
            carType.AddCarReservation(new CarReservationEntity(0, "Test1", "Test1", "Test1", "Test1", "Test1", DateTime.Now.Date));
            
            var result = await carReservationProcess.MakeReservation(new CarReservationEntity(0, "Test1", "Test1", "Test1", "Test1", "Test1", DateTime.Now.Date));
            Assert.False(result.Success);
            var resultCarTypeNotFound= await carReservationProcess.MakeReservation(new CarReservationEntity(1, "Test1", "Test1", "Test1", "Test1", "Test1", DateTime.Now.Date));
            Assert.False(resultCarTypeNotFound.Success);
        }
        
    }
}
