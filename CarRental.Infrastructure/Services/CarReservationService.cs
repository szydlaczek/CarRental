﻿using CarRental.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Services
{
    public class CarReservationService : ICarReservationService
    {
        public CarReservationService(ICarReservationRepository carReservationRepository)
        {

        }

        public Task CreateCarReservation()
        {
            throw new NotImplementedException();
        }

        
    }
}
