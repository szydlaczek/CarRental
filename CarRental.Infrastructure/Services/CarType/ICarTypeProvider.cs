﻿using CarRental.Infrastructure.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Services.CarType
{
    public interface ICarTypeProvider : IService
    {
        Task<IEnumerable<CarTypeViewModel>> GetAllCarTypes();
    }
}
