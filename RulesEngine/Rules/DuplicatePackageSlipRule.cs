using RulesEngine.Interfaces;
using RulesEngine.Models;

namespace RulesEngine.Rules
{
    public class DuplicatePackageSlipRule : IRule
    {
        public string Execute(int paymentType)
        {
            return "Duplicate package slip generated";
        }

        public bool IsApplicable(int paymentType)
        {
            return paymentType == (int)PaymentProduct.Book;
        }
    }
}
