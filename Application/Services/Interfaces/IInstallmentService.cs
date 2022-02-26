using Application.Commands.Installment;
using Domain.KeyLessEntity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IInstallmentService
    {
        Task<List<GetInstallment>> GetAllInstallment(Guid loanId);
        Task PayInstallment(PayInstallment pay);
    }
}
