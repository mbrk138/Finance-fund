using Application.Commands.User;
using Application.Services.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers
{
    public class UserHandler : IRequestHandler<RegisterUserCommand>
    {
        private readonly IIdentityService _service;
        public UserHandler(IIdentityService service)
        {
            _service = service; 
        }
        public async Task<Unit> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
             await _service.RegisterAsync(request);
            return Unit.Value;
        }
    }
}
