using CSharpCalculator;
using NUnit.Framework;


namespace CalculatorNUnitTests
{
    [TestFixture]
    public class SubtractionOfNegativeNumbersTests
    {
        [TestCase(-5, -3, -2)]
        [TestCase(-40, -75, 35)]
        [TestCase(-215, -375, 160)]
        public void SubtractionOfNegativeNumbersTest(double numberOne,
            double numberTwo, double expectedResult)
        {
            var substract = new Calculator();

            double result = substract.Sub(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
