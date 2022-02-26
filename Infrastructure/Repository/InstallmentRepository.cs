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
    public class InstallmentRepository : GenericRepositoryy<Installment>, IInstallmentRepository
    {
        public InstallmentRepository(DatabaseContext context) : base(context) { }
        public List<GetInstallment> GetAllInstallment(Guid loanId)
        {
            return _context.getInstallments.FromSqlRaw($"select [PayDate],[Amount],[ReciptId],[IsPayed], [dbo].[Installments].[Id] InstallmentId ,ROW_NUMBER() OVER (order By [PayDate] ) InstallmentNumber from[dbo].[Installments] where [LoanId] = '{loanId}' order By[PayDate]").ToList();
        }



    }
}
