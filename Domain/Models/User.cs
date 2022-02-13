using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class User : IdentityUser
    {
        public User(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
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
        public List<Fund> Funds { get; private set; }
        public List<Transaction> Transactions { get; private set; }
        public List<CreditCard> CreditCards { get; private set; }
        private User() { }

    }
}

