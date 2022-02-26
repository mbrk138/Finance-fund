using Application.Commands.Installment;
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
    public class InstallmentService:IInstallmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        public InstallmentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<GetInstallment>> GetAllInstallment(Guid loanId)
        {
           return _unitOfWork.Installment.GetAllInstallment(loanId);
        }

        public async Task PayInstallment(PayInstallment pay)
        {
            var installment= await _unitOfWork.Installment.GetByIdAsync(pay.InstallmentId);
            installment.Pay(pay.ReciptId);
            await _unitOfWork.transaction.AddAsync(new Transaction(PaymentInfo.InstallmenPayment, pay.UserId, DateTime.Now, installment.Amount));
            await _unitOfWork.CompleteAsync();
        }


         
    }
}
