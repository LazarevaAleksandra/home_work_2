using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorMSTests
{
    [TestClass]
    public class DivisionTests
    {
        [TestMethod]
        public void DivisionTest()
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