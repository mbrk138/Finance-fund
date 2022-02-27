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
    [Authorize]
    [Route("api/[controller]")] 
    [ApiController]
    public class UsersController : ApiController
    {
        private readonly IIdentityService _identity;

        public UsersController(IIdentityService identityService)
        {
            _identity = identityService;
        }

        [HttpPost("Register-Admin")]
        public async Task<IActionResult> RegisterAsync([FromBody] RegisterUserCommand command)
        {
            if (CurrentUser.Roles!= "SuperAdmin")    
                return BadReq("دسترسی به این بخش فقط برای ادمین اصلی میباشد");

            command.Validate();

            await _identity.RegisterAsync(command);
            return OkResult(ApiMessage.Ok);
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<IActionResult> LoginAsync([FromBody] UserLoginCommand command)
        {
            var jwtToken = await _identity.LoginAsync(command);
            return OkResult(ApiMessage.Ok, jwtToken);
        }


    }
}
