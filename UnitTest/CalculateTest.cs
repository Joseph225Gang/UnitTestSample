using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTestSample.Interface;

namespace UnitTest
{
    [TestFixture()]
    public class CalculateTest
    {

    [Test()]
    public void Test_GetStarted_ReturnAddedValue()
    {
       ICalculator calculator = Substitute.For<ICalculator>();
       calculator.Add(2, 3).Returns(5);
 
       int actual = calculator.Add(2, 3);
       Assert.AreEqual(5, actual);
    }
}
}
