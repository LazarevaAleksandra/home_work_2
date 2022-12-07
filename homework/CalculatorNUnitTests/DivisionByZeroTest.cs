using CSharpCalculator;
using NUnit.Framework;


namespace CalculatorNUnitTests
{
    [TestFixture]
    public class DivisionByZeroTest
    {
        //The test failed. Throws 0 instead of an exception.

        [TestCase(5, 0, typeof(DivideByZeroException)]
        [TestCase(8, 0, typeof(DivideByZeroException))]
        [TestCase(10, 0, typeof(DivideByZeroException))]
        public void Test_DivisionByZero(double numberOne, 
            double numberTwo, Type expectedResult)
        {
            var divisionByZero = new Calculator();

            Assert.Throws(expectedResult , () =>
            divisionByZero.Divide(numberOne, numberTwo));
        }
    }
}
