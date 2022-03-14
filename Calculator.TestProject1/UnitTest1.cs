using System;
using Xunit;

namespace Calculator.TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void AdditionTest()
        {
            double expectedResult = 9;

            double num1 = 6;
            double num2 = 3;

            double actualResult = Program.Addition(num1, num2);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void AdditionArrayTest()
        {
            double[] numberArray = { 1.3, 5.1, 0.5, 1.2 };

            double expectedResult = 8.1;

            double actualResult = Program.Addition(numberArray);

            Assert.Equal(expectedResult, actualResult, 1);
        }

        [Fact]
        public void SubtractionTest()
        {
            double num1 = 6;
            double num2 = 3;

            double expectedResult = 3;

            double actualResult = Program.Subtraction(num1, num2);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void SubtractionArrayTest()
        {
            double[] inArray = { 5.5, 1.2, 0.5, 1.2 };

            double expectedResult = (2.6);

            double actualResult = Program.Subtraction(inArray);

            Assert.Equal(expectedResult, actualResult, 1);
        }

        [Fact]
        public void MultiplicationTest()
        {
            double num1 = 6;
            double num2 = 3;

            double expectedResult = 18;

            double actualResult = Program.Multiplication(num1, num2);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void DivisionTest()
        {
            double num1 = 6;
            double num2 = 3;

            double expectedResult = 2;

            double actualResult = Program.Division(num1, num2);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void DivideByZero()
        {
            
            double expectedResult = 0;

            double actualResult = Program.Division(5, 0);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
