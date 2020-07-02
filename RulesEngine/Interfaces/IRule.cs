using System;
using System.Collections.Generic;
using System.Text;

namespace RulesEngine.Interfaces
{
    public interface IRule
    {
        bool IsApplicable(int paymentType);

        string Execute(int paymentType);
    }
}
