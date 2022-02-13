using Application.Commands.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IIdentityService
    {
        Task RegisterAsync(RegisterUserCommand command);
        Task<string> LoginAsync();
    }
}
