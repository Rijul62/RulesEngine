using RulesEngine.Interfaces;
using RulesEngine.Models;
using System;

namespace RulesEngine.Rules
{
    public class FIrstAidVideoRule : IRule
    {
        public string Execute(int paymentType)
        {
            return "Free first aid video added";
        }

        public bool IsApplicable(int paymentType)
        {
            return paymentType == (int)PaymentProduct.LearningSkiVideo;
        }
    }
}
