using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Commands.Account
{
    public class AccountCommand
    {
        public Guid FundId { get; set; }
        public string OwnerName { get;  set; }
        public string ShabaNumber { get;  set; }
        public string CardNumber { get;  set; }
        public string AccountNumber { get; set; }
    }
}
