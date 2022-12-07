using CSharpCalculator;
using NUnit.Framework;

namespace CalculatorNUnitTests
{
    [TestFixture]
    public class SquareRootOfANegativeNumberTest
    {
        [Test]
        public void Test_SquareRootOfANegativeNumber()
        {
            double numberOne = -5;
            var expectedResult = typeof(Exception);

            var squareRoot = new Calculator();

            Assert.Throws(expectedResult, () => squareRoot.Sqrt(numberOne));
        }
    }
}
