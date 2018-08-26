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
        public IEnumerable<CarTypeEntity> Get(ISpecification<CarTypeEntity> specification)
        {
            return _context.Set<CarTypeEntity>()
                .Where(specification.IsSatisfiedBy)
                .AsEnumerable();
        }

        public CarTypeEntity GetCarTypeById(int id)
        {
            return _context.Set<CarTypeEntity>().Where(d => d.CarTypeId == id).FirstOrDefault();
        }
    }
}
