using Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Commands.Loan
{
    public class AddLoanCommand : IRequest
    {
        public decimal Amount { get; set; }
        public string UserId { get; set; }
        /// <summary>
        /// چندم ماه باید واریز کنه 
        /// </summary>
        public string DayOfMonth { get; set; }

        public DateTime StartInstallment { get; set; }  
        public LoanType LoanType { get; set; }
        public int InstallmentCount { get; set; }
    }
}
