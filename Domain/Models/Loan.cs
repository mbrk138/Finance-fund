using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Loan
    {
        public Loan(decimal amount, string userId, string dayOfMonth, LoanType loanType, int installmentCount, DateTime startInstallment)
        {
            Id = Guid.NewGuid();
            Amount = amount;
            UserId = userId;
            DayOfMonth = dayOfMonth;
            LoanType = loanType;
            InstallmentCount = installmentCount;
            StartInstallment = startInstallment;
            BuildInstallMents();
        }

        public Guid Id { get; private set; }
        public decimal Amount { get; private set; }
        public string UserId { get; private set; }
        /// <summary>
        /// چندم ماه باید واریز کنه 
        /// </summary>
        public string DayOfMonth { get; private set; }
        public LoanType LoanType { get; private set; }
        public int InstallmentCount { get; set; }
        public DateTime StartInstallment { get; set; }
        public List<Installment> Installments { get; private set; }
        private Loan() { }

        public void BuildInstallMents()
        {
            var InstallmentAmount = Amount / InstallmentCount;
            var installmentTime = StartInstallment;
            Installments = new List<Installment>();
            for (int i = 0; i < InstallmentCount; i++)
            {
                Installments.Add(new Installment(installmentTime, InstallmentAmount));
                installmentTime.AddMonths(1);
            }
        }



    }
}
