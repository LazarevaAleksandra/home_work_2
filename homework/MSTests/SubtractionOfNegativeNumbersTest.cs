using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorMSTests
{
    [TestClass]
    public class SubtractionOfNegativeNumbersTest
    {
        [DataTestMethod]
        [DataRow(-5, -3, -2)]
        [DataRow(-40, -75, 35)]
        [DataRow(-215, -375, 160)]
        public void Test_SubtractionOfNegativeNumbers(double numberOne, 
            double numberTwo, double expectedResult)
        {
            var substract = new Calculator();

            double result = substract.Sub(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }

    }
}
