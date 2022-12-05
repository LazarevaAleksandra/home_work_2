using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorMSTests
{
    [TestClass]
    public class MultiplicationTest
    {
        [TestMethod]
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
