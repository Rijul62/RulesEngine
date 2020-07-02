using RulesEngine.Interfaces;
using RulesEngine.Rules;
using System;
using System.Collections.Generic;

namespace RulesEngine
{
    public class RulesEngine
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rules Engine");
            var getRules = ExecuteRule(3);
            foreach(var item in getRules)
            {
                Console.WriteLine(item);
            }
        }

        public static string[] ExecuteRule(int paymentType)
        {
            var rules = new IRule[] {
                new CommissionAgentRule(),
                new DuplicatePackageSlipRule(),
                new FIrstAidVideoRule(),
                new MembershipActivatedRule(),
                new PackageSlipRule(),
                new SentEmailRule(),
            };

            return new RulesEvaluator(rules).Execute(paymentType);
        }
    }
}
