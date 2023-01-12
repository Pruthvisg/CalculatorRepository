using NUnit;
using NUnit.Framework;
using System;
using CalculatorLib;

namespace CalculatorLib.Tests
{
    [TestFixture]
    public class CalculatorTest
    {
        [TestCase]
        public void Add_When_Both_Inputs_GreaterThanZero_Returns_ExpectedResult()
        {
            // Arrange
            Calculator calculator= new Calculator();

            int firstNum = 30;
            int secondNum = 20;
            int expectedResult = 50;
            int actualResult;

            // Act
            actualResult = calculator.Add(firstNum, secondNum);

            // Assert
            Assert.That(expectedResult == actualResult, "Verify the add method logic");
        }

        [TestCase]
        public void Add_When_FirstNum_Greater_Than_Zero_and_SecondNum_LessThanOrEqualTo_Zer0()
        {
            // Arrange
            Calculator calculator = new Calculator();

            int firstNum = 30;
            int secondNum = -20;
            int expectedResult = -1;
            int actualResult;

            // Act
            actualResult = calculator.Add(firstNum, secondNum);

            // Assert
            Assert.That(expectedResult == actualResult, "Verify the add method logic");
        }

        [TestCase]
        public void Add_When_firstNum_IsLessThanOrEqualTo_Zero_and_secondNum_Greater_Than_Zero()
        {
            // Arrange
            Calculator calculator = new Calculator();

            int firstNum = -30;
            int secondNum = 20;
            int expectedResult = -2;
            int actualResult;

            // Act
            actualResult = calculator.Add(firstNum, secondNum);

            // Assert
            Assert.That(expectedResult == actualResult, "Verify the add method logic");
        }

        [TestCase]
        public void Add_When_Both_Inputs_LessThan_Zero()
        {
            // Arrange
            Calculator calculator = new Calculator();

            int firstNum = -30;
            int secondNum = -20;
            int expectedResult = 0;
            int actualResult;

            // Act
            actualResult = calculator.Add(firstNum, secondNum);

            // Assert
            Assert.That(expectedResult == actualResult, "Verify the add method logic");
        }
    }
}
