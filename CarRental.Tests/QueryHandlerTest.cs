using Xunit;
using Moq;
using CarRental.Infrastructure.Handlers.Query.Car;
using CarRental.Infrastructure.ApplicationDbContext;
using CarRental.Infrastructure.EFDbContext;
using CarRental.Core.Domain;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;

namespace CarRental.Tests
{
    
    public class QueryHandlerTest
    {
        [Fact]
        public async Task QueryCartypes_should_return_all_cartypes()
        {
            var data = new List<CarTypeEntity>
            {
                new CarTypeEntity("Test", 200, 5, 2, 200)

            }.AsQueryable();
            
            var mockSet = new Mock<DbSet<CarTypeEntity>>();
            mockSet.As<IDbAsyncEnumerable<CarTypeEntity>>()
                .Setup(m => m.GetAsyncEnumerator())
                .Returns(new TestDbAsyncEnumerator<CarTypeEntity>(data.GetEnumerator()));
            mockSet.As<IQueryable<CarTypeEntity>>()
                .Setup(m => m.Provider)
                .Returns(new TestDbAsyncQueryProvider<CarTypeEntity>(data.Provider));

            mockSet.As<IQueryable<CarTypeEntity>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<CarTypeEntity>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<CarTypeEntity>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockcontext = new Mock<IDbContext>();
            mockcontext.Setup(m => m.Set<CarTypeEntity>()).Returns(mockSet.Object);
           
            CarTypesListQueryHandler query = new CarTypesListQueryHandler(mockcontext.Object);
            var result = await query.RetrievieAll();
            Assert.Single(result);

        }
    }
}