using Application.Commands.Loan;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Mappers
{
    public static class LoanMapper
    {
        public static Loan ToModel(this AddLoanCommand command)
        {
            return new Loan(command.Amount, command.UserId,
                command.DayOfMonth, command.LoanType
                , command.InstallmentCount,command.StartInstallment);
        }




    }
}
