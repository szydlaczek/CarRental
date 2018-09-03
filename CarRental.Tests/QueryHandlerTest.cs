using CarRental.Core.Domain;
using CarRental.Infrastructure.EFDbContext;
using CarRental.Infrastructure.Handlers.Query.Car;
using Moq;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace CarRental.Tests
{
    public class QueryHandlerTest : BaseTest
    {
        [Fact]
        public async Task QueryCartypes_should_return_all_cartypes()
        {    
            CarTypesListQueryHandler queryHandler = new CarTypesListQueryHandler(mockcontext.Object);
            var result = await queryHandler.RetrievieAll();
            Assert.Single(result);
        }
    }
}