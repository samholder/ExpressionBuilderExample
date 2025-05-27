using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLib;

namespace CalculatorLib.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_PositiveNumbers_ReturnsSum()
        {
            var calc = new Calculator();
            Assert.AreEqual(5, calc.Add(2, 3));
        }

        // Subtract, Multiply, Divide are not tested, so Stryker will find surviving mutants
    }
}
