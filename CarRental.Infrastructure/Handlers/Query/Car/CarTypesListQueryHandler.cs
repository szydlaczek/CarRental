using CarRental.Core.Domain;
using CarRental.Infrastructure.EFDbContext;
using CarRental.Infrastructure.Query;
using CarRental.Infrastructure.Query.CarReservation;
using CarRental.Infrastructure.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Handlers.Query.Car
{
    public class CarTypesListQueryHandler : IQueryHandler<CarTypeViewModel>, IQueryHandler<CarTypeQuery, CarTypeViewModel>
    {
        private readonly IDbContext _context;

        public CarTypesListQueryHandler(IDbContext context)
        {
            _context = context;
        }

        public Task<CarTypeViewModel> Retrieve(CarTypeQuery query)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CarTypeViewModel>> RetrievieAll()
        {
            return await _context.CarType.Select(s => new CarTypeViewModel { Id = s.Id, Name = s.Name }).ToListAsync();
        }
    }
}