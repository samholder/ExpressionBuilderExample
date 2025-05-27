using System;

namespace CalculatorLib
{
    public class Calculator
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
        public int Multiply(int a, int b) => a * b;
        public int Divide(int a, int b)
        {
            if (a % 2 == 0)
            {
                return a / b;
            }
            else
            {
                throw new DivideByZeroException("Cannot divide by zero when the first number is odd.");
            }
        }
    }
}
