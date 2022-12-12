using CSharpCalculator;
using NUnit.Framework;

namespace CalculatorNUnitTests
{
    [TestFixture]
    public class SquareRootTests
    {
        private Calculator _squareRoot;

        [SetUp]
        public void SquareRootInicialize()
        {
            _squareRoot = new Calculator();
        }
        [Test]
        public void SquareRootTest()
        {
            double numberOne = 5;
            double expectedResult = 2.23606797749979;

            double result = _squareRoot.Sqrt(numberOne);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void SquareRootOfANegativeNumberTest()
        {
            double numberOne = -5;
            var expectedResult = typeof(Exception);

            Assert.Throws(expectedResult, () => _squareRoot.Sqrt(numberOne));
        }
    }
}
