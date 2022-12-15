using CSharpCalculator;
using NUnit.Framework;

namespace CalculatorNUnitTests
{
    [TestFixture]
    public class SubtractionTests
    {
        private Calculator _substraction;
        
        [SetUp]
        public void SubstractionInicialize()
        {
            _substraction = new Calculator();
        }
        [Test]
        public void SubstractionTest()
        {
            //The test failed on the subtraction of fractional numbers
            //(Expected:<2,4>. Actual:<2,4000000000000004>).

            double numberOne = 5.4;
            double numberTwo = 3;
            double expectedResult = 2.4;

            double result = _substraction.Sub(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(-5, -3, -2)]
        [TestCase(-40, -75, 35)]
        [TestCase(-215, -375, 160)]
        public void SubtractionOfNegativeNumbersTest(double numberOne,
            double numberTwo, double expectedResult)
        {
            double result = _substraction.Sub(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
