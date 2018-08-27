using CarRental.Core.Domain;
using CarRental.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Infrastructure.ApplicationDbContext;
using CarRental.Core.Specifications;
using System.Data.Entity;

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

        public async Task<List<CarTypeEntity>> GetAllCarTypes()
        {
            return await _context.CarType.ToListAsync();
        }

        public async Task<CarTypeEntity> GetCarTypeById(int id)
        {
            return await _context.Set<CarTypeEntity>().Where(d => d.CarTypeId == id).FirstOrDefaultAsync();
        }
    }
}
