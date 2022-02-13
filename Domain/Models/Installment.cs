using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Installment
    {
        public Installment(DateTime payDate, decimal amount)
        {
            Id = Guid.NewGuid();
            PayDate = payDate;
            Amount = amount;
        }

        public decimal Amount { get; set; }
        public Guid Id { get; private set; }
        public string ReciptId { get; private set; }  
        public bool IsPayed { get; private set; }
        /// <summary>
        /// تاریخ پرداخت 
        /// </summary>
        public DateTime PayDate { get; private set; }
        private Installment() { }

        public void Pay(string reciptId)
        {
            IsPayed = true;
            ReciptId = reciptId;
        }

    }
}
