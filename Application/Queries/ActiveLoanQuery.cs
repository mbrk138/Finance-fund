using Domain.KeyLessEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries
{
    public class ActiveLoanQuery : BaseQuery<List<ActiveLoan>>
    {
        public string UserId { get ; set ; }
    }
}
