using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator :AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.LicencePlate).MaximumLength(8);
            RuleFor(p => p.VehicleLicenceNo).NotEmpty().WithMessage("Ruhsat seri numarası alanı boş bırakılamaz!");
        }
    }
}
