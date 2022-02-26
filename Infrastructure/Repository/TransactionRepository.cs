using Domain.Interfaces.RepositoryInterfaces;
using Domain.Models;
using Infrastructure.GenericRepository;
using Infrastructure.Persist;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
    public class TransactionRepository : GenericRepositoryy<Transaction>, ITransactionRepository
    {
        public TransactionRepository(DatabaseContext context) : base(context) { }










    }
}
