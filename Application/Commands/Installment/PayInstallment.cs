using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Commands.Installment
{
    public class PayInstallment : IRequest
    {
        public Guid UserId { get; set; }
        public Guid InstallmentId { get; set; } 
        public string ReciptId { get; set; }
    }
}
