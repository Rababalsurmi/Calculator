using System;
using Xunit;
using CalculatorLibrary;

namespace Calculator.Tests
{
    
    public class CalculatorTest
    {
        
        [Fact]
        public void Add()
        {
            //arrange

            //string op = "a";
            double num1 = 5;
            double num2 = 3;
            double expected = 8;

            //CalculatorLibrary.Calculator testcalculator = null;
            //testcalculator = new CalculatorLibrary.Calculator(num1, num2, op);
            //act
            var actual = CalculatorLibrary.Calculator.Add(num1, num2);

            //Assert
            Assert.Equal(expected, actual, 0);
        }
    }
}
