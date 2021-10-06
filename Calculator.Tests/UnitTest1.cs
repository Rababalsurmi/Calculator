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

            double num1 = 5;
            double num2 = 3;
            double expected = 8;

            //act
            var actual = CalculatorLibrary.Calculator.Add(num1, num2);

            //Assert
            Assert.Equal(expected, actual, 0);
        }
        [Theory]
        [InlineData(3, 6, 9)]
        [InlineData(4, 3, 7)]
        [InlineData(-10, 10, 0)]
        [InlineData(34, 5.33, 39.33)]
        [InlineData(-10, -10, -20)]
        public void AddArray(double expected, params double[] n)
        {
            // Action
            double actual = CalculatorLibrary.Calculator.Add(n);

            // Assertion
            Assert.Equal(expected, actual, 0);
        }

        [Fact]
        public void Substract()
        {
            //arrange
            double x1 = 10;
            double x2 = 8;
            double expected = 2;

            //act
            var actual = CalculatorLibrary.Calculator.Subtract(x1, x2);

            //assert
            Assert.Equal(expected, actual, 0);
        }
        [Theory]
        [InlineData(3, 6, 9)]
        [InlineData(4, 3, 7)]
        [InlineData(-10, 10, 0)]
        [InlineData(34, 5.33, 39.33)]
        [InlineData(-10, -10, -20)]
        public void SubstractArray(double expected, params double[] n)
        {
            //act
            var actual = CalculatorLibrary.Calculator.Subtract(n);

            //assert
            Assert.Equal(expected, actual, 0);
        }

        [Theory(DisplayName = "Maths- Divided with parameters")]
        [InlineData(40, 8, 5)]
        public void Divide(double value1, double value2, double value3)
        {
            //arrange
            double x1 = value1;
            double x2 = value2;
            double expected = value3;

            //act
            var actual = CalculatorLibrary.Calculator.Divide(x1, x2);

            //assert
            Assert.Equal(expected, actual, 0);
        }

        [Fact(Skip = "Do not run now")]
        public void Multiply()
        {
            //arrange
            double x1 = 5;
            double x2 = 8;
            double expected = 40;

            //act
            var actual = CalculatorLibrary.Calculator.Multiply(x1, x2);

            //assert
            Assert.Equal(expected, actual, 0);
        }

        [Fact(DisplayName = "Maths - Divide by Zero Exception")]
        public void DivideByZeroException()
        {
            //arrange
            double a = 100;
            double b = 0;

            //act
            Action act = () => CalculatorLibrary.Calculator.Divide(a, b);

            //assert
            Assert.Throws<DivideByZeroException>(act);
        }
    }
}
