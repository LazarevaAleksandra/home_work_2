using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorMSTests
{
    [TestClass]
    public class SquareRootTest
    {
        [TestMethod]
        public void Test_SquareRoot()
        {
            double numberOne = 5;
            double expectedResult = 2.23606797749979;

            var squareRoot = new Calculator();
            double result = squareRoot.Sqrt(numberOne);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
