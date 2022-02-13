using Application.Commands.Loan;
using Domain.KeyLessEntity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface ILoanService
    {
        Task AddLoan(AddLoanCommand command);
        List<ActiveLoan> GetActiveLoans();
    }
}
