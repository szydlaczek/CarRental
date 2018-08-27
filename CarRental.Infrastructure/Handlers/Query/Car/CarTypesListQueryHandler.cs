using CarRental.Infrastructure.Query;
using CarRental.Infrastructure.Query.CarReservation;
using CarRental.Infrastructure.Services.CarType;
using CarRental.Infrastructure.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Handlers.Query.Car
{
    public class CarTypesListQueryHandler : IQueryHandler<CarTypeViewModel>, IQueryHandler<CarTypeQuery, CarTypeViewModel>
    {
        public readonly ICarTypeProvider _carTypeProvider;
        public CarTypesListQueryHandler(ICarTypeProvider carTypeProvider)
        {
            _carTypeProvider = carTypeProvider;
        }

        public Task<CarTypeViewModel> Retrieve(CarTypeQuery query)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CarTypeViewModel>> RetrievieAll()
        {
            return await _carTypeProvider.GetAllCarTypes();
        }
    }
}
