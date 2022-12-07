using CSharpCalculator;
using NUnit.Framework;

namespace CalculatorNUnitTests
{
    [TestFixture]
    public class SquareRootTest
    {
        [Test]
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
