using CarRental.Core.Domain;
using CarRental.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Infrastructure.ApplicationDbContext;
using CarRental.Core.Specifications;

namespace CarRental.Infrastructure.Repositories
{
    public  class CarTypeRepository : ICarTypeRepository
    {
        private readonly ApplicationContext _context;
        public CarTypeRepository(ApplicationContext context)
        {
            _context = context;
        }
        public IEnumerable<CarType> Get(ISpecification<CarType> specification)
        {
            return _context.Set<CarType>()
                .Where(specification.IsSatisfiedBy)
                .AsEnumerable();
        }

        public CarType GetCarTypeById(int id)
        {
            return _context.Set<CarType>().Where(d => d.Id == id).FirstOrDefault();
        }
    }
}
