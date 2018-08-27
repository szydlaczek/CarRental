using CarRental.Infrastructure.ViewModels;
using FluentValidation;

namespace CarRental.Infrastructure.Validation
{
    public class CarReservationValidator : AbstractValidator<CarReservationViewModel>
    {
        public CarReservationValidator()
        {
        }
    }
}