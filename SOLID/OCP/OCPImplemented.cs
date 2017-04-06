using System;
using System.Collections.Generic;

namespace SOLID.OCP
{
    public interface IDiscountCalculate
    {
        bool Rule(string ruleName);
        Double Calculate(int amount);
    }

    public class SummerDiscount : IDiscountCalculate
    {
        public bool Rule(string ruleName)
        {
            return "Summer".Equals(ruleName);
        }

        public double Calculate(int amount)
        {
            return amount*0.15;
        }
    }

    public class WinterDiscount : IDiscountCalculate
    {
        public bool Rule(string ruleName)
        {
            return "Winter".Equals(ruleName);
        }

        public double Calculate(int amount)
        {
            return amount * 0.10;
        }
    }

    public class ChristmasDiscount : IDiscountCalculate
    {
        public bool Rule(string ruleName)
        {
            return "Christmas".Equals(ruleName);
        }

        public double Calculate(int amount)
        {
            return amount * 0.30;
        }
    }

    public class IndependenceDayDiscount : IDiscountCalculate
    {
        public bool Rule(string ruleName)
        {
            return "IDay".Equals(ruleName);
        }

        public double Calculate(int amount)
        {
            return amount * 0.05;
        }
    }

    public class DiscountCalculatorOcp
    {
        public List<IDiscountCalculate> DiscountService;

        public DiscountCalculatorOcp()
        {
            DiscountService = new List<IDiscountCalculate>
            {
                new SummerDiscount(),
                new WinterDiscount(),
                new ChristmasDiscount(),
                new IndependenceDayDiscount()
            };
        }

        public double CalculateDiscount(int amount, string rule)
        {
            var discountedValue = DiscountService.Find(i => i.Rule(rule)).Calculate(amount);
            return discountedValue;
        }
    }
}
