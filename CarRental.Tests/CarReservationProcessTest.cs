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
    public class CarReservationProcessTest
    {
        public CarReservationProcessTest()
        {

        }
        [Fact]
        public async Task makereservation_should_invoke_savechanges_on_dbcontext()
        {
            //var command=new CreateCarReservation
            //{
            //    City = "TestCity",
            //    PostCode = "57-400",
            //    Name = "TestName",
            //    CarTypeId = 0,
            //    PhoneNumber = "55555555",
            //    ReservationDate = "2018-08-08",
            //    Street = "TestStreet"
            //};
            //var carType = new CarTypeEntity("Test", 200, 5, 4, 200);
            //carType.AddCarReservation(new CarReservationEntity(0,"Nowa Ruda", "Nowa Ruda", "Nowa Ruda", "Nowa Ruda", "Nowa Ruda", DateTime.Now));
            //List<CarTypeEntity> carTypeList = new List<CarTypeEntity>();
            //carTypeList.Add(carType);
            //var data = carTypeList.AsQueryable();

            //var mockSet = new Mock<DbSet<CarTypeEntity>>();
            //mockSet.As<IDbAsyncEnumerable<CarTypeEntity>>()
            //    .Setup(m => m.GetAsyncEnumerator())
            //    .Returns(new TestDbAsyncEnumerator<CarTypeEntity>(data.GetEnumerator()));
            //mockSet.As<IQueryable<CarTypeEntity>>()
            //    .Setup(m => m.Provider)
            //    .Returns(new TestDbAsyncQueryProvider<CarTypeEntity>(data.Provider));

            //mockSet.As<IQueryable<CarTypeEntity>>().Setup(m => m.Expression).Returns(data.Expression);
            //mockSet.As<IQueryable<CarTypeEntity>>().Setup(m => m.ElementType).Returns(data.ElementType);
            //mockSet.As<IQueryable<CarTypeEntity>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            //var mockcontext = new Mock<IDbContext>();
            //mockcontext.Setup(m => m.Set<CarTypeEntity>()).Returns(mockSet.Object);
            //CarReservationProcess carReservationProcess = new CarReservationProcess(mockcontext.Object);
            //await carReservationProcess.MakeReservation(command.CarTypeId, command.Name, command.PhoneNumber, command.PostCode, command.City, command.Street, command.GetReservationDate());
            //mockcontext.Verify(x => x.SaveChangesAsync(), Times.Once);
        }    
    }
}
