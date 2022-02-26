using Application.Commands.User;
using Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finance_fund.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]
    public class UsersController : ApiController
    {
        private readonly IIdentityService _identity;

        public UsersController(IIdentityService identityService)
        {
            _identity = identityService;
        }

        [AllowAnonymous]
        [HttpPost("Register-Admin")]
        public async Task<IActionResult> RegisterAsync([FromBody] RegisterUserCommand command)
        {
            command.Validate();

            await _identity.RegisterAsync(command);
            return OkResult(ApiMessage.Ok);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> LoginAsync([FromBody] UserLoginCommand command)
        {
            var jwtToken = await _identity.LoginAsync(command);
            return OkResult(ApiMessage.Ok, jwtToken);
        }


    }
}
