using CSharpCalculator;
using NUnit.Framework;

namespace CalculatorNUnitTests
{
    [TestFixture]
    public class DivisionOfFractionalNumbersTests
    {
        [Test]
        [TestCase(5.4, 3.1, 1.7419354838709677)]
        [TestCase(4.5, 6.7, 0.6716417910447761)]
        [TestCase(12.8, 5.4, 2.3703703703703702)]
        public void DivisionOfFractionalNumbersTest(double numberOne, 
            double numberTwo, double expectedResult)
        {
            var division = new Calculator();

            double result = division.Divide(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
