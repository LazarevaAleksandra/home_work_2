using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorMSTests
{
    [TestClass]
    public class SquareRootTests
    {
        [TestMethod]
        public void SquareRootTest()
        {
            double numberOne = 5;
            double expectedResult = 2.23606797749979;

            var squareRoot = new Calculator();
            double result = squareRoot.Sqrt(numberOne);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Error!")]
        public void SquareRootOfANegativeNumberTest()
        {
            double numberOne = -5;

            var squareRoot = new Calculator();

            double result = squareRoot.Sqrt(numberOne);

            Assert.ThrowsException<Exception>(() => result);
        }
    }
}
