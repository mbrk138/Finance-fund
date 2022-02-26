using Application.Commands.Installment;
using Application.Queries;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finance_fund.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstallmentController : ApiController
    {
        

        [HttpPut]
        public async Task<IActionResult> PayInstallment(PayInstallment payInstallment)
        {
            await Mediator.Send(payInstallment);
            return OkResult(ApiMessage.Ok);
        }


    }
}
