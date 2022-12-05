using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorMSTests
{
    [TestClass]
    public class AdditionTest
    {
        [TestMethod]
        public void Test_Addition()
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
