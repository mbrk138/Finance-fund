using Application.Services.Interfaces;
using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Classes
{
    public class TransactionService: ITransactionservice
    {
        private readonly IGenericRepository<Transaction> _transact;
        public TransactionService(IGenericRepository<Transaction> transact)
        {
            _transact = transact;
        }

        public async Task<List<Transaction>> GetTransactionsAsync()
        {
            var transactions= await _transact.GetAll();
            return transactions.ToList();
        }


    }
}
