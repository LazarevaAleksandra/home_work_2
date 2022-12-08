using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorMSTests
{
    [TestClass]
    public class SubtractionTests
    {
        //The test failed on the subtraction of fractional numbers
        //(Expected:<2,4>. Actual:<2,4000000000000004>).

        [TestMethod]
        public void SubstractionTest()
        {
            double numberOne = 5.4;
            double numberTwo = 3;
            double expectedResult = 2.4;

            var substraction = new Calculator();
            double result = substraction.Sub(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }

        [DataTestMethod]
        [DataRow(-5, -3, -2)]
        [DataRow(-40, -75, 35)]
        [DataRow(-215, -375, 160)]
        public void SubtractionOfNegativeNumbersTest(double numberOne,
            double numberTwo, double expectedResult)
        {
            var substract = new Calculator();

            double result = substract.Sub(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
