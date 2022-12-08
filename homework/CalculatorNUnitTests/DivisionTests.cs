using CSharpCalculator;
using NUnit.Framework;


namespace CalculatorNUnitTests
{
    [TestFixture]
    public class DivisionTests
    {
        [Test]
        public void DivisionTest()
        {
            double numberOne = 45;
            double numberTwo = 5;
            double expectedResult = 9;

            var division = new Calculator();
            double result = division.Divide(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }
    }
}