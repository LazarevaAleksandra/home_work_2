﻿using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorMSTests
{
    [TestClass]
    public class DivisionByZeroTest
    {
        //The test failed and did not throw the expected exception.

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException),
    "You can't divide by 0!")]
        public void Test_DivizionByZero()
        {
            double numberOne = 5;
            double numberTwo = 0;

            var divisionByZero = new Calculator();
            double result = divisionByZero.Divide(numberOne, numberTwo);           
        }
    }
}


//The test worked and threw the expected exception.

//    [TestMethod]
//    [ExpectedException(typeof(DivideByZeroException),
//"You can't divide by 0!")]
//    public void Test_DivizionByZero()
//    {
//        double numberOne = 5;
//        double numberTwo = 0;

//        var divisionByZero = new Calculator();
//        double result = divisionByZero.Divide(numberOne, numberTwo);

//        if (numberTwo == 0.0)
//            throw new DivideByZeroException();
//        Console.WriteLine(numberOne / numberTwo);

//        Assert.ThrowsException<DivideByZeroException>(() =>
//        divisionByZero.Divide(numberOne, numberTwo));
//    }

//I don't like the implementation. But it works!