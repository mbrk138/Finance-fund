﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class CreditCard
    {
        public CreditCard(string ownerName, string shabaNumber, string cardNumber, string accountNumber,Guid fundId)
        {
            Id = Guid.NewGuid();
            OwnerName = ownerName;
            ShabaNumber = shabaNumber;
            CardNumber = cardNumber;
            AccountNumber = accountNumber;
            FundId = fundId;
        }
        public Guid Id { get; private set; }
        public Guid FundId { get; set; }    
        public string OwnerName { get; private set; }
        public string ShabaNumber { get; private set; }
        public string CardNumber { get; private set; }
        public string AccountNumber { get; private set; }
        private CreditCard() { }
    }
}
