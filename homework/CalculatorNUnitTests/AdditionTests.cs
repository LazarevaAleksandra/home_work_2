using CSharpCalculator;
using NUnit.Framework;

namespace CalculatorNUnitTests
{
    [TestFixture]
    public class AdditionTests
    {
        [Test]
        public void AdditionTest()
        {
            double numberOne = 2.5;
            double numberTwo = 3.4;
            double expectedResult = 5.9;

            var addition = new Calculator();
            double result = addition.Add(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }
    }
}