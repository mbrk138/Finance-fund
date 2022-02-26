﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface ITransactionservice
    {
        Task<List<Transaction>> GetTransactionsAsync();
    }
}
