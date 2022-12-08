using CSharpCalculator;
using NUnit.Framework;

namespace CalculatorNUnitTests
{
    [TestFixture]
    public class MultiplicationTests
    {
        [Test]
        public void MultiplicationTest()
        {
            double numberOne = 5;
            double numberTwo = 10;
            double expectedResult = 50;

            var multiplication = new Calculator();
            double result = multiplication.Multiply(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
