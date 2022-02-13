using Application.Commands.Loan;
using Application.Services.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers
{
    public class LoanCommandHandler : IRequestHandler<AddLoanCommand>
    {
        private readonly ILoanService _service;
        public LoanCommandHandler(ILoanService service)
        {
            _service = service;
        }
        public async Task<Unit> Handle(AddLoanCommand request, CancellationToken cancellationToken)
        {
            await _service.AddLoan(request);
            return Unit.Value;
        }
    }
}
