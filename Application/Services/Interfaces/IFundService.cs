using Application.Commands.Account;
using Application.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IFundService
    {
        Task<AccountDto> GetAccountDto(Guid fundId);
        Task<FundDto> GetFundDto(string userId);
        Task<List<UserDto>> GetUsers(Guid fundId,string userid);
        Task AddAccount(AccountCommand command);
    }
}
