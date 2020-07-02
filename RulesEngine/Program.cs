using RulesEngine.Interfaces;
using RulesEngine.Rules;
using System;

namespace RulesEngine
{
    public class RulesEngine
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rules Engine");
            Console.WriteLine(ExecuteRule(3));
        }

        private static string ExecuteRule(int paymentType)
        {
            var rules = new IRule[] {
                new CommissionAgentRule(),
                new DuplicatePackageSlipRule(),
                new FirstAidVideoRule(),
                new MembershipActivatedRule(),
                new PackageSlipRule(),
                new SentEmailRule(),
            };

            return new RulesEvaluator(rules).Execute(paymentType);
        }
    }
}
