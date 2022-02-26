﻿using Domain.KeyLessEntity;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.RepositoryInterfaces
{
    public interface ILoanRepository : IGenericRepository<Loan>
    {
        List<ActiveLoan> GetAllActive(string userId);
        List<DisActiveLoan> GetAllPayed(string userId);
        List<DisactiveLoanMore> GetAllPayedMore(string userId);
        List<ActiveLoanMore> GetAllActiveMore(string userId);
    }
}
