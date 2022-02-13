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
    public class LoanRepository: GenericRepository<Loan>,ILoanRepository
    {
        public LoanRepository(DatabaseContext context) : base(context) { }

        /// <summary>
        /// باید Asyncronouns شه
        /// </summary>
        public List<ActiveLoan> GetAllActive()
        {
            return _context.ActiveLoans.FromSqlRaw("select users.UserName,[Amount],[DayOfMonth],[LoanType]from[Vamioon].[dbo].[Loans] loan join[Vamioon].[dbo].[AspNetUsers] users on users.Id = loan.UserId where loan.Id = ANY(select[LoanId] from[Vamioon].[dbo].[Installments] where Installments.IsPayed = 0)").ToList();
        }

        /// <summary>
        /// تاریخ تسویه هم برمیگردونه
        /// که یک entity جدا میخواد
        /// </summary>
        public async Task<List<ActiveLoan>> GetAllPayed()
        {
            return await _context.ActiveLoans.FromSqlRaw("select [UserName],[Amount],[DayOfMonth],[LoanType]from[dbo].[Loans] loan join[dbo].[AspNetUsers] users on users.Id = loan.UserIdwhere loan.Id = ANY(select[LoanId] from[dbo].[Installments] where Installments.IsPayed = 0)").ToListAsync();

        }

    }
}
