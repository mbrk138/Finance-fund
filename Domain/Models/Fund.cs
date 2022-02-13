using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Fund
    {
        public Fund(string fundName)
        {
            Id = Guid.NewGuid();
            FundName = fundName;
        }
        public Guid Id { get; private set; }
        public string FundName { get; private set; }
        public DateTime FundSubmitDate { get; private set; }
        public Guid AdminId { get; private set; }
        public string FundRules { get; private set; }
        private Fund() { }

    }
}
