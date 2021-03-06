﻿using CarRental.Infrastructure.Command.CarReservation;
using CarRental.Infrastructure.Converters;
using FluentValidation;
using System;

namespace CarRental.Infrastructure.Validation
{
    public class CarReservationValidator : AbstractValidator<CreateCarReservation>
    {
        public CarReservationValidator()
        {
            RuleFor(x => x.CarTypeId).NotEmpty().WithMessage("Wybierz typ pojazdu");
            RuleFor(x => x.City)
                .NotNull()
                .WithMessage("To pole jest wymagane");

            RuleFor(x => x.Name)
                .NotNull()
                .WithMessage("To pole jest wymagane");

            RuleFor(x => x.PostCode)
                .Matches("^[0-9]{2}-[0-9]{3}$")
                .WithMessage("Zły format kodu pocztowego")
                .NotNull()
                .WithMessage("To pole jest wymagane");

            RuleFor(x => x.Street)
                .NotNull()
                .WithMessage("To pole jest wymagane");

            RuleFor(x => x.PhoneNumber)
                .Matches("^[1-9]{1}[0-9]{8}")
                .WithMessage("Nie prawidłowy format telefonu")
                .NotNull()
                .WithMessage("To pole jest wymagane");

            RuleFor(x => x.ReservationDate)
                .NotNull()
                .WithMessage("To pole jest wymagane")
                .Must(BeValidDate)
                .WithMessage("Podaj datę w formacie yyyy-mm-dd")
                .Must(BeFutureDate)
                .WithMessage("Podaj późniejszą datę");
        }

        private bool BeValidDate(string value)
        {
            DateTime date;
            return DateFromString.Convert(value, out date);
        }

        private bool BeFutureDate(string value)
        {
            DateTime date;

            DateFromString.Convert(value, out date);
            if (date <= DateTime.Now.Date)
                return false;
            else
                return true;
        }
    }
}