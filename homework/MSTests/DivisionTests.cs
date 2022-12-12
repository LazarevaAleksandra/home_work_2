using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorMSTests
{  
    [TestClass]
    public class DivisionTests
    {
        [TestMethod]
        public void DivisionTest()
        {
            double numberOne = 45;
            double numberTwo = 5;
            double expectedResult = 9;

            var division = new Calculator();
            double result = division.Divide(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException),
       "You can't divide by 0!")]
        public void DivizionByZeroTest()
        {
            double numberOne = 5;
            double numberTwo = 0;

            var divisionByZero = new Calculator();

            if (numberTwo == 0.0)
                throw new DivideByZeroException();
            Console.WriteLine(numberOne / numberTwo);

            Assert.ThrowsException<DivideByZeroException>(() =>
            divisionByZero.Divide(numberOne, numberTwo));
        }

        [DataTestMethod]
        [DataRow(5.4, 3.1, 1.7419354838709677)]
        [DataRow(4.5, 6.7, 0.6716417910447761)]
        [DataRow(12.8, 5.4, 2.3703703703703702)]
        public void DivisionOfFractionalNumbersTest(double numberOne,
            double numberTwo, double expectedResult)
        {
            var division = new Calculator();

            double result = division.Divide(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }
    }
}