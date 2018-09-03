using CarRental.Core.Domain;
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

namespace CarRental.Tests
{
    public abstract class BaseTest
    {
        protected List<CarTypeEntity> carTypeList;        
        protected Mock<IDbSet<CarTypeEntity>> mockSet;
        protected Mock<IDbContext> mockcontext = new Mock<IDbContext>();
        protected Mock<ICarReservationProcess> _reservationProcessMock = new Mock<ICarReservationProcess>();
        public BaseTest()
        {
            carTypeList = new List<CarTypeEntity>();
            carTypeList.Add(new CarTypeEntity("Test", 200, 5, 2, 200));
            mockSet= new Mock<IDbSet<CarTypeEntity>>();
            var data = carTypeList.AsQueryable();

            mockSet.As<IDbAsyncEnumerable<CarTypeEntity>>()
                .Setup(m => m.GetAsyncEnumerator())
                .Returns(new TestDbAsyncEnumerator<CarTypeEntity>(data.GetEnumerator()));
            mockSet.As<IQueryable<CarTypeEntity>>()
                .Setup(m => m.Provider)
                .Returns(new TestDbAsyncQueryProvider<CarTypeEntity>(data.Provider));

            mockSet.As<IQueryable<CarTypeEntity>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<CarTypeEntity>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<CarTypeEntity>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());


            mockcontext.Setup(m => m.CarType).Returns(mockSet.Object);
        }
    }
}
