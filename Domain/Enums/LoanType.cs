using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Domain.Enums
{
    public enum LoanType
    {
        [Description("فوری")] Urgent = 1,
        [Description("کمک هزینه ")] Subsidy = 2,
        [Description("خرید جهیزیه ")] Jahiziyeh = 3,
        [Description("تحصیلی ")] Educational = 4
    }
}
