using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dto
{
    public class FundDto
    {
        public Guid Id { get; set; }
        public string FundName { get; set; }
        public DateTime FundSubmitDate { get; set; }
        public string AdminName { get; set; }
        public string AdminId { get; set; }
        public string FundRules { get; set; }
    }
}
