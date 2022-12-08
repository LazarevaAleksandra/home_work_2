using CSharpCalculator;
using NUnit.Framework;

namespace CalculatorNUnitTests
{
    [TestFixture]
    public class SquareRootOfANegativeNumberTest
    {
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
