using Domain.Interfaces.RepositoryInterfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IFundRepository Funds { get;  }
        ILoanRepository Loan { get; }
        IInstallmentRepository Installment { get; }
        ITransactionRepository transaction { get; }
        IGenericRepository<CreditCard> credit { get; }

        Task CompleteAsync();
    }
}
