using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Fund
    {
        public Fund(string fundName,string adminName,string adminId,Guid fundId)
        {
            Id = fundId;
            UserId = adminId;
            FundName = fundName;
            AdminName = adminName;
            FundSubmitDate = DateTime.Now;
        }
        public Guid Id { get;  set; }
        public string FundName { get;  set; }
        public DateTime FundSubmitDate { get; set; }
        public string AdminName { get;  set; }
        public string UserId { get; set; }
        public string FundRules { get; private set; }
        public Fund() { }




    }
}
