using Application.Commands.Account;
using Application.Dto;
using Application.Services.Interfaces;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Classes
{
    public class FundService : IFundService
    {

        private readonly IUnitOfWork _unitOfWork;
        public FundService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddAccount(AccountCommand command)
        {
            await _unitOfWork.credit.AddAsync(new Domain.Models.CreditCard(command.OwnerName, command.ShabaNumber, command.AccountNumber, command.AccountNumber,command.FundId));
            await _unitOfWork.CompleteAsync();
        }

        public async Task<AccountDto> GetAccountDto(Guid fundId)
        {
            var card= await _unitOfWork.Funds.GetCardByUserId(fundId);
            return new AccountDto { AccountNumber = card.AccountNumber, CardNumber = card.CardNumber, Id = card.Id, OwnerName = card.OwnerName, ShabaNumber = card.ShabaNumber };
        }

        public async Task<FundDto> GetFundDto(string userId)
        {
            var fund= await _unitOfWork.Funds.GetFundByUserId(userId);
            return new FundDto { AdminId = fund.UserId, AdminName = fund.AdminName, FundName = fund.FundName, FundRules = fund.FundRules, FundSubmitDate = fund.FundSubmitDate, Id = fund.Id };
        }

        public async Task<List<UserDto>> GetUsers(Guid fundId,string userid)
        {
            var users= await _unitOfWork.Funds.GetUserByFundId(fundId,userid);
            List<UserDto> userDtos = new List<UserDto>();
            users.ForEach(u => userDtos.Add(new UserDto { FullName = u.FullName, NationalCode = u.NationalCode, ProfilePicture = u.ProfilePicture }));
            return userDtos;
        }

    }
}
