using CSharpCalculator;
using NUnit.Framework;

namespace CalculatorNUnitTests
{
    [TestFixture]
    public class MultiplicationTests
    {
        private Calculator _multiplication;

        [SetUp]
        public void MultiplicationInicialize()
        {
            _multiplication = new Calculator();
        }
        [Test]
        public void MultiplicationTest()
        {
            double numberOne = 5;
            double numberTwo = 10;
            double expectedResult = 50;

            double result = _multiplication.Multiply(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(-5, -3, 15)]
        [TestCase(-40, -75, 3000)]
        [TestCase(-215, -375, 80625)]
        public void MultiplicationOfNegativeNumbersTest(double numberOne,
           double numberTwo, double expectedResult)
        {
            double result = _multiplication.Multiply(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
