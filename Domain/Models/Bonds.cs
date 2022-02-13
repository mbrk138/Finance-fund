using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Bonds
    {
        public bool IsBought { get; private set; }
        public decimal Price { get; set; }
        public Guid FundId { get; set; }
        public string UserId { get; set; }

    }
}
