using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dto
{
    public class AccountDto
    {
        public Guid Id { get;  set; }
        public string OwnerName { get;  set; }
        public string ShabaNumber { get;  set; }
        public string CardNumber { get;  set; }
        public string AccountNumber { get;  set; }
    }
}
