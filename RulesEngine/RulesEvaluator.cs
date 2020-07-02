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

        public string[] Execute(int paymentType)
        {
            List<string> response = new List<string>(); ;
            if (paymentType == (int)PaymentProduct.DefaultProduct)
            {
                response.Add("Default product selected. No rules to generate");
                return response.ToArray();
            }

            var result = _rules
                        .Where(rule => rule.IsApplicable(paymentType))
                        .Select(rule => rule.Execute(paymentType));

            if (result != null
                && result.Any())
            {
                foreach(var item in result.ToList())
                {
                    response.Add(item);
                }
                return response.ToArray();
            }
            else
            {
                response.Add("Invalid product selected");
                return response.ToArray();
            }
        }
    }
}
