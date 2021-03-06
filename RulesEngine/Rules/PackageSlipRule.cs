﻿using RulesEngine.Interfaces;
using RulesEngine.Models;
using System;

namespace RulesEngine.Rules
{
    public class PackageSlipRule : IRule
    {
        public string Execute(int paymentType)
        {
            return "Package slip generated";
        }

        public bool IsApplicable(int paymentType)
        {
            return paymentType == (int)PaymentProduct.PhysicalProduct;
        }
    }
}
