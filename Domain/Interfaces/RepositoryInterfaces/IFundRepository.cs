using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.RepositoryInterfaces
{
    public interface IFundRepository
    {
        Task<Fund> GetFundByUserId(string userId);
        Task<CreditCard> GetCardByUserId(Guid fundId);
        Task<List<User>> GetUserByFundId(Guid fundId,string userid);
    }
}
