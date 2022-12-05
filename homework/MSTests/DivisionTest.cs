using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorMSTests
{
    [TestClass]
    public class DivisionTest
    {
        [TestMethod]
        public void Test_Division()
        {
            double numberOne = 45;
            double numberTwo = 5;
            double expectedResult = 9;

            var division = new Calculator();
            double result = division.Divide(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }
    }
}