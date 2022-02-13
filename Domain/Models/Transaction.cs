using Domain.Enums;
using System;

namespace Domain.Models
{
    public class Transaction
    {
        public Transaction(PaymentInfo paymentInfo, Guid userId, DateTime date, decimal amount)
        {
            Id = Guid.NewGuid();
            PaymentInfo = paymentInfo;
            UserId = userId;
            Date = date;
            Amount = amount;
        }
        public Guid Id { get; private set; }
        public PaymentInfo PaymentInfo { get; private set; }
        public Guid UserId { get; private set; }
        public DateTime Date { get; private set; }
        public decimal Amount { get; private set; }
        public Transaction()
        {

        }
    }

}
