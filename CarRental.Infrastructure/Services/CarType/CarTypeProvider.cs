using CarRental.Core.Repositories;
using CarRental.Infrastructure.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Services.CarType
{
    public class CarTypeProvider : ICarTypeProvider
    {
        private readonly ICarTypeRepository _carTypeRepository;
        public CarTypeProvider(ICarTypeRepository carTypeRepository)
        {
            _carTypeRepository = carTypeRepository;
        }
        public async Task<IEnumerable<CarTypeViewModel>> GetAllCarTypes()
        {
            var carTypeList = await _carTypeRepository.GetAllCarTypes();
            var result = carTypeList.Select(d => new CarTypeViewModel { Id = d.CarTypeId, Name = d.Name });
            return result;
        }
    }
}
