using CSharpCalculator;
using NUnit.Framework;

namespace CalculatorNUnitTests
{
    [TestFixture]
    public class MultiplicationTest
    {
        [Test]
        public void Test_Multiplication()
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
