using Domain.Interfaces;
using Domain.Interfaces.RepositoryInterfaces;
using Domain.Models;
using Infrastructure.GenericRepository;
using Infrastructure.Persist;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
            Funds = new FundRepository(_context);
            Loan = new LoanRepository(_context);
            Installment = new InstallmentRepository(_context);
            transaction = new TransactionRepository(_context);
            credit = new GenericRepositoryy<CreditCard>(_context);
        }

        public IFundRepository Funds { get; private set;  }

        public ILoanRepository Loan { get; private set; }

        public IInstallmentRepository Installment { get; private set; }

        public ITransactionRepository transaction { get; private set; }

        public IGenericRepository<CreditCard> credit { get; private set; }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
