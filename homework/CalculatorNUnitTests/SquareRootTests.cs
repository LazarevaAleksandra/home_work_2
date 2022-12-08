using CSharpCalculator;
using NUnit.Framework;

namespace CalculatorNUnitTests
{
    [TestFixture]
    public class SquareRootTests
    {
        [Test]
        public void SquareRootTest()
        {
            double numberOne = 5;
            double expectedResult = 2.23606797749979;

            var squareRoot = new Calculator();
            double result = squareRoot.Sqrt(numberOne);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void SquareRootOfANegativeNumberTest()
        {
            double numberOne = -5;
            var expectedResult = typeof(Exception);

            var squareRoot = new Calculator();

            Assert.Throws(expectedResult, () => squareRoot.Sqrt(numberOne));
        }
    }
}
