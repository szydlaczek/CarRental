using CarRental.Infrastructure.Handlers.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using CarRental.Infrastructure.Services.CarReservation;
using CarRental.Infrastructure.Command.CarReservation;
using Xunit;
using CarRental.Core.Domain;

namespace CarRental.Tests
{
    public class CommandHandlerTest
    {
        public CommandHandlerTest()
        {

        }
        [Fact]
        public async Task HandleAsync_should_invoke_makeReservation_on_CarReservationProcess()
        {
            var _reservationProcessMock = new Mock<ICarReservationProcess>();
            CreateCarReservationHandler handler = new CreateCarReservationHandler(_reservationProcessMock.Object);
            CreateCarReservation command = new CreateCarReservation();
            command.CarTypeId = 1;
            command.City = "Nowa Ruda";

            await handler.HandleAsync(new CreateCarReservation
            {
                City = "TestCity",
                PostCode = "57-400",
                Name = "TestName",
                CarTypeId = 1,
                PhoneNumber = "55555555",
                ReservationDate = "2018-08-08",
                Street = "TestStreet"
            });
            _reservationProcessMock
                .Verify(x => x.MakeReservation(It.IsAny<CarReservationEntity>()), Times.Once);
        }
    }
}
