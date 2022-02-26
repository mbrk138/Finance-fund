using Domain.KeyLessEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries
{
    public class DisactiveLoanQuery :BaseQuery<List<DisActiveLoan>>
    {
        public string UserId { get; set; }
    }
}
