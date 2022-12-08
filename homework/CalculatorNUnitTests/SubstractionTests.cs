using CSharpCalculator;
using NUnit.Framework;

namespace CalculatorNUnitTests
{
    [TestFixture]
    public class SubtractionTests
    {
        //The test failed on the subtraction of fractional numbers
        //(Expected:<2,4>. Actual:<2,4000000000000004>).

        [Test]
        public void SubstractionTest()
        {
            double numberOne = 5.4;
            double numberTwo = 3;
            double expectedResult = 2.4;

            var substraction = new Calculator();
            double result = substraction.Sub(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
