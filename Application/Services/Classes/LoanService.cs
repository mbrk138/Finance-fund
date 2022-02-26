using Application.Commands.Loan;
using Application.Mappers;
using Application.Services.Interfaces;
using Domain.Enums;
using Domain.Interfaces;
using Domain.KeyLessEntity;
using Domain.Models;
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
            await _unitOfWork.transaction.AddAsync(new Transaction(PaymentInfo.LoanGivment, Guid.Parse(command.UserId), DateTime.Now, command.Amount));
            await _unitOfWork.CompleteAsync();
        }

        /// <summary>
        /// بخش وام
        /// سمت راست پنل ادمین 
        /// </summary>
        public List<ActiveLoan> GetActiveLoans(string userId)
        {
            return _unitOfWork.Loan.GetAllActive(userId);
        }
        public List<ActiveLoanMore> GetActiveLoansMore(string userId)
        {
            return _unitOfWork.Loan.GetAllActiveMore(userId);
        }
        public List<DisActiveLoan> GetDisactiveLoans(string userId)
        {
            return _unitOfWork.Loan.GetAllPayed(userId);
        }
        public List<DisactiveLoanMore> GetDisactiveLoansMore(string userId)
        {
            return _unitOfWork.Loan.GetAllPayedMore(userId);
        }
    }
}
