using CarRental.Core.Domain;
using CarRental.Core.Repositories;
using CarRental.Core.Specifications;
using CarRental.Infrastructure.ApplicationDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Repositories
{
    public class CarReservationRepository : ICarReservationRepository
    {
        private readonly ApplicationContext _context;
        public CarReservationRepository(ApplicationContext context)
        {
            _context = context;
        }
        public IEnumerable<CarTypeEntity> Get(ISpecification<CarReservationEntity> specification)
        {
            throw new NotImplementedException();
        }
    }
}
