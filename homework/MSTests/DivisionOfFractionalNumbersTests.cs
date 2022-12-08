using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorMSTests
{
    [TestClass]
    public class DivisionOfFractionalNumbersTests
    {
        [DataTestMethod]
        [DataRow(5.4, 3.1, 1.7419354838709677)]
        [DataRow(4.5, 6.7, 0.6716417910447761)]
        [DataRow(12.8, 5.4, 2.3703703703703702)]
        public void DivisionOfFractionalNumbersTest(double numberOne, 
            double numberTwo, double expectedResult )
        {
            var division = new Calculator();

            double result = division.Divide(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
