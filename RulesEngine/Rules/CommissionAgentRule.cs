using RulesEngine.Interfaces;
using RulesEngine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RulesEngine.Rules
{
    public class CommissionAgentRule : IRule
    {
        public string Execute(int paymentType)
        {
            return "Generated free commission agent";
        }

        public bool IsApplicable(int paymentType)
        {
            var isPhysicalProduct = paymentType == (int)PaymentProduct.PhysicalProduct;
            var isBook = paymentType == (int)PaymentProduct.Book;

            return isPhysicalProduct || isBook;
        }
    }
}
