using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.KeyLessEntity
{
    public class GetInstallment
    {
        public DateTime PayDate { get; set; }
        public decimal Amount { get; set; }
        public string ReciptId { get; set; }
        public bool IsPayed { get; set; }
        public long InstallmentNumber { get; set; }
        public Guid InstallmentId { get; set; }
    }
}
