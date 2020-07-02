using RulesEngine.Interfaces;
using RulesEngine.Models;
using System;

namespace RulesEngine.Rules
{
    public class UpgradeRule : IRule
    {
        public string Execute(int paymentType)
        {
            return "Upgraded";
        }

        public bool IsApplicable(int paymentType)
        {
            return paymentType == (int)PaymentProduct.Upgrade;
        }
    }
}
