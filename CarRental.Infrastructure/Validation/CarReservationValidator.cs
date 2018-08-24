using CarRental.Infrastructure.ViewModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Validation
{
    public class CarReservationValidator : AbstractValidator<CarReservationViewModel>
    {
        public CarReservationValidator()
        {
            
        }
        
    }
}
