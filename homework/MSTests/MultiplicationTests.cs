using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorMSTests
{
    [TestClass]
    public class MultiplicationTests
    {
        [TestMethod]
        public void MultiplicationTest()
        {
            double numberOne = 5;
            double numberTwo = 10;
            double expectedResult = 50;

            var multiplication = new Calculator();
            double result = multiplication.Multiply(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }

        [DataTestMethod]
        [DataRow(-5, -3, 15)]
        [DataRow(-40, -75, 3000)]
        [DataRow(-215, -375, 80625)]
        public void MultiplicationOfNegativeNumbersTest(double numberOne,
            double numberTwo, double expectedResult)
        {
            var multiplication = new Calculator();

            double result = multiplication.Multiply(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
