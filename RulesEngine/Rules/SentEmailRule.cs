using RulesEngine.Interfaces;
using RulesEngine.Models;

namespace RulesEngine.Rules
{
    public class SentEmailRule : IRule
    {
        public string Execute(int paymentType)
        {
            return "Email sent for activation/upgrade";
        }

        public bool IsApplicable(int paymentType)
        {
            var isMembership = paymentType == (int)PaymentProduct.Membership;
            var isUpgrade = paymentType == (int)PaymentProduct.Upgrade;

            return isMembership || isUpgrade;
        }
    }
}
