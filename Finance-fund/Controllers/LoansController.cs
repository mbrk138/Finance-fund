using Application.Commands.Loan;
using Application.Queries;
using Application.Services.Interfaces;
using Domain.Enums;
using Finance_fund.Controllers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vamioon.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class LoansController : ApiController
    {
        private readonly ILoanService _loanService;

        public LoansController(ILoanService loanService)
        {
            _loanService = loanService;
        }
        
        [HttpGet("Disactive")]
        public async Task<IActionResult> GetActiveLoansAsync()
        {
            if (CurrentUser.Roles == UserRoles.Member.ToString())
                throw new Exception("ورود غیر مجاز");

            var activeLoans =await Mediator.Send(new ActiveLoanQuery { UserId = CurrentUser.Id });
            return OkResult(ApiMessage.Ok, activeLoans);
        }

        [HttpGet("Disactive-More")]
        public async Task<IActionResult> GetMoreActiveLoansAsync()
        {
            if (CurrentUser.Roles == UserRoles.Member.ToString())
                throw new Exception("ورود غیر مجاز");

            var activeLoans =await Mediator.Send(new ActiveLoaneMoreQuery { UserId = CurrentUser.Id });
            return OkResult(ApiMessage.Ok, activeLoans);
        }

        [HttpGet("Active")]
        public async Task<IActionResult> GetDisActiveLoansAsync()
        {
            if (CurrentUser.Roles == UserRoles.Member.ToString())
                throw new Exception("ورود غیر مجاز");

            var activeLoans =await Mediator.Send(new DisactiveLoanQuery { UserId = CurrentUser.Id });
            return OkResult(ApiMessage.Ok, activeLoans);
        }
        
        [HttpGet("Active-More")]
        public async Task<IActionResult> GetMoreDisActiveLoansAsync()
        {
            if (CurrentUser.Roles==UserRoles.Member.ToString())
                throw new Exception("ورود غیر مجاز");
           
            var activeLoans =await Mediator.Send(new DisactiveLoanMoreQuery { UserId = CurrentUser.Id });
            return OkResult(ApiMessage.Ok, activeLoans);
        }

        [HttpGet("{id}/getinstallments")]
        public async Task<IActionResult> GetAllInstallment(Guid id)
        {
            var installment = await Mediator.Send(new GetInstallmentQuery { LoanId = id });
            return OkResult(ApiMessage.Ok, installment);
        }

        [HttpPost]
        public async Task<IActionResult> AddLoanAsync([FromBody] AddLoanCommand command)
        {
            if (CurrentUser.Roles == UserRoles.Member.ToString())
                throw new Exception("ورود غیر مجاز");

            await Mediator.Send(command);
            return OkResult(ApiMessage.Ok);
        }



    }
}
