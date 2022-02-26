using Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finance_fund.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController:ApiController
    {
        private readonly ITransactionservice transactionservice;

        public TransactionsController(ITransactionservice transactionservice)
        {
            this.transactionservice = transactionservice;
        }

        [HttpGet]
        public async Task<IActionResult> getTransaction()
        {
            var transactions = await transactionservice.GetTransactionsAsync();
            return OkResult(ApiMessage.Ok,transactions);
        }









    }
}
