using CarRental.Infrastructure.Command.CarReservation;
using CarRental.Infrastructure.ViewModels;
using FluentValidation;

namespace CarRental.Infrastructure.Validation
{
    public class CarReservationValidator : AbstractValidator<CreateCarReservation>
    {
        public CarReservationValidator()
        {
            RuleFor(x => x.City).NotNull().WithMessage("Nie null").NotEmpty().WithMessage("Nie puste");
        }
    }
}