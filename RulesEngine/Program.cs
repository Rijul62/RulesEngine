using RulesEngine.Interfaces;
using RulesEngine.Rules;
using System;

namespace RulesEngine
{
    public class RulesEngine
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static void ExecuteRule(int paymentType)
        {
            var rules = new IRule[] {
                new CommissionAgentRule(),
                new DuplicatePackageSlipRule(),
                new FirstAidVideoRule(),
                new MembershipActivatedRule(),
                new PackageSlipRule(),
                new SentEmailRule(),
            };
        }
    }
}
