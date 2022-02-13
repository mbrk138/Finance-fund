using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.KeyLessEntity
{
    public class DisActiveLoan
    {
        public string UserName { get; set; }
        public decimal Amount { get; set; }

        public LoanType LoanType { get; set; }
    }
}
