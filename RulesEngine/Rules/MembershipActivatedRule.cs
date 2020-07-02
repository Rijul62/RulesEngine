using RulesEngine.Interfaces;
using RulesEngine.Models;
using System;

namespace RulesEngine.Rules
{
    public class MembershipActivatedRule : IRule
    {
        public string Execute(int paymentType)
        {
            return "Membership activated";
        }

        public bool IsApplicable(int paymentType)
        {
            return paymentType == (int)PaymentProduct.Membership;
        }
    }
}
