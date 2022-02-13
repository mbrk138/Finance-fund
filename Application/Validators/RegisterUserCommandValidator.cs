using Application.Commands.User;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Validators
{
    public class RegisterUserCommandValidator : AbstractValidator<RegisterUserCommand>
    {
        public RegisterUserCommandValidator()
        {
            RuleFor(x => x.PhoneNumber)
            .NotNull().WithMessage("شماره تلفن نمیتواند خالی باشد ")
            .MaximumLength(11).WithMessage("شماره تلفن حداکثر 11 رقم ")
            .MinimumLength(11).WithMessage("شماره تلفن حداقل 11 رقم ");


        }
    }
}
