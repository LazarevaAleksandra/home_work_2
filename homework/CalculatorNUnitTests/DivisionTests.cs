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

        //The test failed. Throws 0 instead of an exception.

        [TestCase(5, 0, typeof(DivideByZeroException))]
        [TestCase(8, 0, typeof(DivideByZeroException))]
        [TestCase(10, 0, typeof(DivideByZeroException))]
        public void DivisionByZeroTest(double numberOne,
            double numberTwo, Type expectedResult)
        {
            var divisionByZero = new Calculator();

            Assert.Throws(expectedResult, () =>
            divisionByZero.Divide(numberOne, numberTwo));
        }

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