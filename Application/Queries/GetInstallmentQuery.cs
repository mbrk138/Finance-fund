using Domain.KeyLessEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries
{
    public class GetInstallmentQuery : BaseQuery<List<GetInstallment>>
    {
        public Guid LoanId { get; set; }
    }   
}
