using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Commands
{
    public abstract class CommandBase
    {
        public abstract bool Validate();
    }
}
