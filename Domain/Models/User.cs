using Domain.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    public class User : IdentityUser
    {
        public User(string fundName, UserRoles roles, string fullname, string password)
        {
            FullName = fullname;
           // PhoneNumber = phoneNumber;
            FundId = Guid.NewGuid();
            userRoles = roles;
            Funds = new List<Fund>();
            AddFund(fundName);
            PasswordHash = password;
        }
        public void UpdateProfile(string fullName, string nationalCode, string profilePicture)
        {
            FullName = fullName;
            NationalCode = nationalCode;
            ProfilePicture = profilePicture;
        }

        public string FullName { get; private set; }
        public string NationalCode { get; private set; }
        public string ProfilePicture { get; private set; }
        public Guid FundId { get; set; }
        
        public List<Fund> Funds { get; set; }
        public List<Transaction> Transactions { get; private set; }
        public List<CreditCard> CreditCards { get; private set; }
        public bool IsActive { get; private set; }
        public UserRoles userRoles{ get; set; }
      
        public User() { }

        public void AddFund(string fundName)
        {
            var fund = new Fund(fundName, FullName,Id,FundId);
            Funds.Add(fund);
        }
    }
}

