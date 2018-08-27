using CarRental.Infrastructure.Query;
using CarRental.Infrastructure.Query.CarReservation;
using CarRental.Infrastructure.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Handlers.Query.Car
{
    public class CarTypesListQueryHandler : IQueryHandler<CarTypeViewModel>, IQueryHandler<CarTypeQuery, CarTypeViewModel>
    {
        public CarTypesListQueryHandler()
        {
        }

        public Task<CarTypeViewModel> Retrieve(CarTypeQuery query)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CarTypeViewModel>> RetrievieAll()
        {
            return null;
        }
    }
}