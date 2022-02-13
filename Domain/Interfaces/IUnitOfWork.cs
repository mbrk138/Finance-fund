using Domain.Interfaces.RepositoryInterfaces;
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
        Task CompleteAsync();
    }
}
