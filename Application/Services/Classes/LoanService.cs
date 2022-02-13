using Application.Commands.Loan;
using Application.Mappers;
using Application.Services.Interfaces;
using Domain.Interfaces;
using Domain.KeyLessEntity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Classes
{
    public class LoanService : ILoanService
    {
        private readonly IUnitOfWork _unitOfWork;
        public LoanService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task AddLoan(AddLoanCommand command)
        {
            var loan = command.ToModel();
            await _unitOfWork.Loan.AddAsync(loan);
            await _unitOfWork.CompleteAsync();
        }

        /// <summary>
        /// بخش وام
        /// سمت راست پنل ادمین 
        /// </summary>
        public List<ActiveLoan> GetActiveLoans()
        {
            return _unitOfWork.Loan.GetAllActive();
        }

    }
}
