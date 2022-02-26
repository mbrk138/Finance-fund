using Application.Commands.Account;
using Application.Dto;
using Application.Queries;
using Application.Services.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
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
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class FundController:ApiController
    {
        private readonly IFundService _fundService;
        public FundController(IFundService fundService)
        {
            _fundService = fundService;
        }

        [HttpGet]
        public async Task<IActionResult> GetFund()
        {
            var Funds = await _fundService.GetFundDto(CurrentUser.Id);
            return OkResult(ApiMessage.Ok, Funds);
        }
        
        [HttpGet("{id}/account")]
        public async Task<IActionResult> GetAccount(Guid id)
        {
            var accounts = await _fundService.GetAccountDto(id);
            return OkResult(ApiMessage.Ok, accounts);
        }
        
        [HttpGet("{id}/Users")]
        public async Task<IActionResult> GetUsers(Guid id)
        {
            List<UserDto> accounts = await _fundService.GetUsers(id,CurrentUser.Id);
            return OkResult(ApiMessage.Ok, accounts);
        }

        [HttpPost("{id}/Addaccount")]
        public async Task<IActionResult> AddAccount(Guid id,AccountCommand command)
        {
            command.FundId = id;
            await _fundService.AddAccount(command);
            return OkResult(ApiMessage.Ok);
        }

    }
}
