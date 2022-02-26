using Application.Commands.Installment;
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
    public class InstallmentHandler :
        IRequestHandler<GetInstallmentQuery, List<GetInstallment>>,
        IRequestHandler<PayInstallment>
    {
        private readonly IInstallmentService _service;
        public InstallmentHandler(IInstallmentService service)
        {
            _service = service;
        }
        public async Task<List<GetInstallment>> Handle(GetInstallmentQuery request, CancellationToken cancellationToken)
        {
            return await _service.GetAllInstallment(request.LoanId);
        }

        public async Task<Unit> Handle(PayInstallment request, CancellationToken cancellationToken)
        {
            await _service.PayInstallment(request);
            return Unit.Value;
        }
    }
}
