using CarRental.Infrastructure.Query;
using CarRental.Infrastructure.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Handlers.Query.Car
{
    public class CarTypesListHandler : IQueryHandler<CarType>
    {
        public Task<CarType> Retrieve()
        {
            throw new NotImplementedException();
        }

        public Task<List<CarType>> RetrievieList()
        {
            throw new NotImplementedException();
        }
    }
}
