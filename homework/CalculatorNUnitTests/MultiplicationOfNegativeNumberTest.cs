using CSharpCalculator;
using NUnit.Framework;


namespace CalculatorNUnitTests
{

    [TestFixture]
    public class MultiplicationOfNegativeNumbersTest
    {
        [TestCase(-5, -3, 15)]
        [TestCase(-40, -75, 3000)]
        [TestCase(-215, -375, 80625)]
        public void Test_MultiplicationOfNegativeNumbers(double numberOne,
            double numberTwo, double expectedResult)
        {
            var multiplication = new Calculator();

            double result = multiplication.Multiply(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
