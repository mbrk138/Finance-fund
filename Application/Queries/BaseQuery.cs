using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries
{
    public interface BaseQuery<out TResult> : IRequest<TResult>
    {
    }
}
