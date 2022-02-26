using Domain.KeyLessEntity;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.RepositoryInterfaces
{
    public interface IInstallmentRepository:IGenericRepository<Installment>
    {
        List<GetInstallment> GetAllInstallment(Guid loanId);
    }
}
