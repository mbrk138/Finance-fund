using Domain.Interfaces;
using Domain.Interfaces.RepositoryInterfaces;
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
        }
        public IFundRepository Funds { get; private set;  }

        public ILoanRepository Loan { get; private set; }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
