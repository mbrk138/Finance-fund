using Application.Validators;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Commands.User
{
    public class RegisterUserCommand : CommandBase,  IRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }    
        public string FundName { get; set; }
        public override bool Validate()
        {
            return new RegisterUserCommandValidator().Validate(this).IsValid;
        }

    }
}
