﻿using CarRental.Core.Domain;
using CarRental.Core.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Core.Repositories
{
    public interface ICarTypeRepository
    {
        IEnumerable<CarType> Get(ISpecification<CarType> specification);
        CarType GetCarTypeById(int id);
    }
}
