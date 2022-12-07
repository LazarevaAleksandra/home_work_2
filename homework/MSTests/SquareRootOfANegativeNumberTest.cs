using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorMSTests
{
    [TestClass]
    public class SquareRootOfANegativeNumberTest
    { 
        [TestMethod]
        [ExpectedException(typeof(Exception), "Error!")]
        public void Test_SquareRootOfANegativeNumber()
        {
            double numberOne = -5;

            var squareRoot = new Calculator();

            double result = squareRoot.Sqrt(numberOne);
            
            Assert.ThrowsException<Exception>(() => result);
        }
    }
}
