using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorMSTests
{
    [TestClass]
    public class SubtractionTest
    {
        [TestMethod]
        public void Test_Substraction()
        {
            double numberOne = 5;
            double numberTwo = 3;
            double expectedResult = 2;

            var substraction = new Calculator();
            double result = substraction.Sub(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
