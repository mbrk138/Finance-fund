using Domain.KeyLessEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries
{
    public class DisactiveLoanMoreQuery: BaseQuery<List<DisactiveLoanMore>>
    {
        public string UserId { get; set; }
}
}
