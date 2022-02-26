using Application.Commands.Loan;
using Application.Queries;
using Application.Services.Interfaces;
using Domain.KeyLessEntity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers
{
    public class LoanCommandHandler : IRequestHandler<AddLoanCommand>,
        IRequestHandler<ActiveLoanQuery, List<ActiveLoan>>,
        IRequestHandler<DisactiveLoanQuery, List<DisActiveLoan>>,
        IRequestHandler<ActiveLoaneMoreQuery, List<ActiveLoanMore>>,
        IRequestHandler<DisactiveLoanMoreQuery, List<DisactiveLoanMore>>

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

        public async Task<List<ActiveLoan>> Handle(ActiveLoanQuery request, CancellationToken cancellationToken)
        {
            return _service.GetActiveLoans(request.UserId);
        }

        public async Task<List<DisActiveLoan>> Handle(DisactiveLoanQuery request, CancellationToken cancellationToken)
        {
            return _service.GetDisactiveLoans(request.UserId);
        }

        public async Task<List<ActiveLoanMore>> Handle(ActiveLoaneMoreQuery request, CancellationToken cancellationToken)
        {
            return _service.GetActiveLoansMore(request.UserId);
        }

        public async Task<List<DisactiveLoanMore>> Handle(DisactiveLoanMoreQuery request, CancellationToken cancellationToken)
        {
            return _service.GetDisactiveLoansMore(request.UserId);
        }






    }
}
