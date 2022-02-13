using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Domain.Enums
{
    public enum PaymentInfo
    {
        [Description("پرداخت قسط ")] InstallmenPayment = 1,
        [Description("اعطای وام ")] LoanGivment = 2
    }
}
