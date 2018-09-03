using CarRental.Infrastructure.Command;
using CarRental.Infrastructure.Query;
using CarRental.Infrastructure.ViewModel;
using CarRental.Web.Controllers;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Xunit;

namespace CarRental.Tests
{
    public class ControllerTest
    {
        [Fact]
        public async Task TestCreateCarReservationView()
        {
            var mockQueryDispatcher = new Mock<IQueryDispatcher>();
            var mockCommandDispatcher = new Mock<ICommandDispatcher>();
            List<CarTypeViewModel> carTypes = new List<CarTypeViewModel>();
            carTypes.Add(new CarTypeViewModel { Id = 1, Name = "Test" });
            mockQueryDispatcher.Setup(q => q.DispatchAll<CarTypeViewModel>()).ReturnsAsync(()=>carTypes);
            CarTypeController controller = new CarTypeController(mockCommandDispatcher.Object, mockQueryDispatcher.Object);
            var result = await controller.CreateCarReservation() as ViewResult;
            Assert.Equal("CreateCarReservation", result.ViewName);
        }
    }
}
