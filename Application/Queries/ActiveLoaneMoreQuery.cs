using Domain.KeyLessEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries
{
    public class ActiveLoaneMoreQuery : BaseQuery<List<ActiveLoanMore>>
    {
        public string UserId { get; set; }
    }
}
