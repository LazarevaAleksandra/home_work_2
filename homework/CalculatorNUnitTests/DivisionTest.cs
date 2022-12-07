using CSharpCalculator;
using NUnit.Framework;


namespace CalculatorNUnitTests
{
    [TestFixture]
    public class DivisionTest
    {
        [Test]
        public void Test_Division()
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