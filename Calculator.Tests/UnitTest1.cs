using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorShould
    {
        private Calculator _calculator;

        public CalculatorShould()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void AddTwoIntegers()
        {
            // Given this input to the method
            int sum = _calculator.Add(54, 29);
            // We are asserting that the output should be this
            Assert.Equal(sum, 83);
        }
        [Fact]
        public void SubtractTwoIntegers() 
        {
            // Given this input to the method
            int sum = _calculator.Subtract(50, 40);
            // We are asserting that the output should be this
            Assert.Equal(sum, 10);
        }
        [Fact]
        public void MultiplyTwoIntegers() 
        {
            // Given this input to the method
            int sum = _calculator.Multiply(10, 21);
            // We are asserting that the output should be this
            Assert.Equal(sum, 210);
        }
        [Fact]
        public void DivideTwoIntegers()
        {
            // Given this input to the method
            int sum = _calculator.Divide(40, 4);
            // We are asserting that the output should be this
            Assert.Equal(sum, 10);
        }
    }
}