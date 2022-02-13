using Application.Commands.Loan;
using Application.Services.Interfaces;
using Finance_fund.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vamioon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoansController : ApiController
    {
        private readonly ILoanService _loanService;

        public LoansController(ILoanService loanService)
        {
            _loanService = loanService;
        }

        [HttpGet("names")]
        public async Task<IActionResult> GetDisActiveLoansAsync()
        {
            //var mentorDtos = await _mentorService.GetAllNames();
            //if (!mentorDtos.Any()) 
            //{
            //    return BadReq(ApiMessage.MentorIsNotValid);
            //}
            //return OkResult(ApiMessage.OkAllMentorsFound, mentorDtos);
            return Ok();
        }

        [HttpGet("Active")]
        public IActionResult GetActiveLoansAsync()
        {
            var activeLoans = _loanService.GetActiveLoans();
            return OkResult(ApiMessage.Ok, activeLoans);
        }

        [HttpPost]
        public async Task<IActionResult> AddLoanAsync([FromBody] AddLoanCommand command)
        {
            await Mediator.Send(command);
            return OkResult(ApiMessage.Ok);
        }



    }
}
