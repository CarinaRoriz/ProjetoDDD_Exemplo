using System;
using FluentValidation;
using DDD.Domain.Entities;

namespace DDD.Service.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(c => c)
                    .NotNull()
                    .OnAnyFailure(x =>
                    {
                        throw new ArgumentNullException("Can't found the object.");
                    });
            
                RuleFor(c => c.Cpf)
                    .NotEmpty().WithMessage("Is necessary to inform the CPF.")
                    .NotNull().WithMessage("Is necessary to inform the CPF.");

                RuleFor(c => c.BirthDate)
                    .NotEmpty().WithMessage("Is necessary to inform the birth date.")
                    .NotNull().WithMessage("Is necessary to inform the birth date.");

                RuleFor(c => c.Name)
                    .NotEmpty().WithMessage("Is necessary to inform the name.")
                    .NotNull().WithMessage("Is necessary to inform the birth date.");
        }
	}
}