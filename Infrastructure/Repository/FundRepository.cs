using Domain.Interfaces.RepositoryInterfaces;
using Domain.Models;
using Infrastructure.GenericRepository;
using Infrastructure.Persist;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class FundRepository : GenericRepositoryy<Fund> , IFundRepository
    {
        public FundRepository(DatabaseContext context ) : base(context)
        {
        }

        public async Task<Fund> GetFundByUserId(string userId)
        {
            return await _context.Funds.FirstOrDefaultAsync(f => f.UserId == userId);
        }

        public async Task<CreditCard> GetCardByUserId(Guid fundId)
        {
            return await _context.CreditCards.FirstOrDefaultAsync(f => f.FundId == fundId);
        }

        public async Task<List<User>> GetUserByFundId(Guid fundId,string userid)
        {
            var users = await _context.Users.Where(u => u.Id == userid).ToListAsync();
            return await _context.Users.Where(u => u.FundId == fundId).Except(users).ToListAsync();

        }



    }
}
