using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorMSTests
{
    [TestClass]
    public class MultiplicationOfNegativeNumbersTest
    {
        [DataTestMethod]
        [DataRow(-5, -3, 15)]
        [DataRow(-40, -75, 3000)]
        [DataRow(-215, -375, 80625)]
        public void Test_MultiplicationOfNegativeNumbers(double numberOne,
            double numberTwo, double expectedResult)
        {
            var multiplication = new Calculator();

            double result = multiplication.Multiply(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
