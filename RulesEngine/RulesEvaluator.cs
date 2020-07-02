using RulesEngine.Interfaces;
using RulesEngine.Models;
using System.Collections.Generic;
using System.Linq;

namespace RulesEngine
{
    public class RulesEvaluator
    {
        private readonly IEnumerable<IRule> _rules;
        public RulesEvaluator(IEnumerable<IRule> rules)
        {
            _rules = rules;
        }

        public string Execute(int paymentType)
        {
            if (paymentType == (int)PaymentProduct.DefaultProduct)
            {
                return "Default product selected. No rules to generate";
            }
            var result = _rules
                        .Where(rule => rule.IsApplicable(paymentType))
                        .Select(rule => rule.Execute(paymentType));

            if (result != null
                && result.Any())
            {
                return result.FirstOrDefault();
            }
            else
            {
                return "Invalid product selected";
            }
        }
    }
}
