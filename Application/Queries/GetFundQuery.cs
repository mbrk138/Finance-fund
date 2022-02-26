using Application.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries
{
    public class GetFundQuery : BaseQuery<List<FundDto>>
    {
        public string UserId { get; set; }
    }
}
