using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorMSTests
{
    [TestClass]
    public class SquareRootOfANegativeNumberTest
    {
        //The test failed. In the actual result,
        //it writes that the given number is not a number, but should return "Error!"
        
        [DataTestMethod]
        [DataRow(-5, "Error!")]
        [DataRow(-40, "Error!")]
        [DataRow(-215, "Error!")]
        public void Test_SquareRootOfANegativeNumber(double numberOne, string expectedResult)
        {
            var squareRoot = new Calculator();

            double result = squareRoot.Sqrt(numberOne);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
