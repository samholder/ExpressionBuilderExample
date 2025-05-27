using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLib;
using System;

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

        [TestMethod]
        public void Subtract_PositiveNumbers_ReturnsDifference()
        {
            var calc = new Calculator();
            Assert.AreEqual(1, calc.Subtract(3, 2));
        }

        [TestMethod]
        public void Multiply_PositiveNumbers_ReturnsProduct()
        {
            var calc = new Calculator();
            Assert.AreEqual(6, calc.Multiply(2, 3));
        }

        [TestMethod]
        public void Divide_PositiveNumbers_ReturnsQuotient()
        {
            var calc = new Calculator();
            Assert.AreEqual(2, calc.Divide(6, 3));
        }

        [TestMethod]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            var calc = new Calculator();
            Assert.ThrowsException<DivideByZeroException>(() => calc.Divide(1, 0));
        }

        [TestMethod]
        public void Divide_ByZero_ErrorMessageIsCorrect()
        {
            var calc = new Calculator();
            var ex = Assert.ThrowsException<DivideByZeroException>(() => calc.Divide(1, 0));
            Assert.AreEqual("Cannot divide by zero when the first number is odd.", ex.Message);
        }
    }
}
