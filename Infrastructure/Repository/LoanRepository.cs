using Domain.Interfaces.RepositoryInterfaces;
using Domain.KeyLessEntity;
using Domain.Models;
using Infrastructure.GenericRepository;
using Infrastructure.Persist;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class LoanRepository: GenericRepositoryy<Loan>,ILoanRepository
    {
        public LoanRepository(DatabaseContext context) : base(context) { } 


        public List<DisActiveLoan> GetAllPayed(string userId)
        {
            return _context.disActiveLoans.FromSqlRaw($"select users.UserName,users.ProfilePicture,[Amount],[DayOfMonth],[LoanType],loan.InstallmentCount,(select top 1 [PayDate] from [dbo].[Installments] order by [PayDate] desc)as 'PayTime' from[Finance].[dbo].[Loans] loan join[Finance].[dbo].[AspNetUsers] users on users.Id = loan.UserId where 0 = Any( select installment.IsPayed from[Finance].[dbo].[Installments] installment where Installment.LoanId = loan.Id) And users.Id='{userId}'").ToList();
        }

        public List<DisactiveLoanMore> GetAllPayedMore(string userId) 
        {
            return _context.DisactiveLoanMores.FromSqlRaw($"select users.UserName,users.ProfilePicture,users.NationalCode,users.PhoneNumber,loan.InstallmentCount,loan.Id loanId,[Amount],[DayOfMonth],[LoanType],(select top 1 [PayDate] from [dbo].[Installments] order by [PayDate] desc)as 'PayTime' from[Finance].[dbo].[Loans] loan join[Finance].[dbo].[AspNetUsers] users on users.Id = loan.UserId where 0 = Any( select installment.IsPayed from[Finance].[dbo].[Installments] installment where Installment.LoanId = loan.Id) And users.Id='{userId}'").ToList();
        }

        public  List<ActiveLoanMore> GetAllActiveMore(string userId)
        {
            return _context.activeLoanMores.FromSqlRaw($"select users.UserName,users.ProfilePicture,users.NationalCode,users.PhoneNumber,loan.InstallmentCount,loan.Id loanId,[Amount],[DayOfMonth],[LoanType] from[Finance].[dbo].[Loans] loan join[Finance].[dbo].[AspNetUsers] users on users.Id = loan.UserId where 1 = All( select installment.IsPayed from[Finance].[dbo].[Installments] installment where Installment.LoanId = loan.Id) And users.Id='{userId}'").ToList();
        }

        public List<ActiveLoan> GetAllActive(string userId)
        {
            return _context.ActiveLoans.FromSqlRaw($"select users.UserName,users.ProfilePicture,loan.InstallmentCount,[Amount],[DayOfMonth],[LoanType] from[Finance].[dbo].[Loans] loan join[Finance].[dbo].[AspNetUsers] users on users.Id = loan.UserId where 1 = All( select installment.IsPayed from[Finance].[dbo].[Installments] installment where Installment.LoanId = loan.Id) And users.Id='{userId}'").ToList();
        }



    }
}
