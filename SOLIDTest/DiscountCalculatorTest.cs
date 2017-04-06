using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOLID.OCP;

namespace SOLIDTest
{
    [TestClass]
    public class DiscountCalculatorTest
    {
        private DiscountCalculatorOcp _discountCalculator;

        [TestInitialize]
        public void TestSetup()
        {
            _discountCalculator = new DiscountCalculatorOcp();
        }

        [TestMethod]
        public void FifteenPercentForSummer()
        {
            var result = _discountCalculator.CalculateDiscount(100, "Summer");
            Assert.AreEqual(15.0, result);
        }

        [TestMethod]
        public void TenPercentForWinter()
        {
            var result = _discountCalculator.CalculateDiscount(100, "Winter");
            Assert.AreEqual(10.0, result);
        }

        [TestMethod]
        public void ThirtyPercentForChristmas()
        {
            var result = _discountCalculator.CalculateDiscount(100, "Christmas");
            Assert.AreEqual(30.0, result);
        }

        [TestMethod]
        public void FiveForIDayDiscount()
        {
            var result = _discountCalculator.CalculateDiscount(100, "IDay");
            Assert.AreEqual(5.0, result);
        }

    }
}
