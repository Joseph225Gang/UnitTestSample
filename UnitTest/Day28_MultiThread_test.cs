using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTestSample.Interface;

namespace UnitTest
{
    [TestFixture()]
    public class Day28_MultiThread_test
    {

        [TestCase(2, 4)]
        public void Equal2Times_PutNumber_ReturnTrue(int targetNO, int testNO)
        {
            Day28_MultiThread testObj = new Day28_MultiThread();

            testObj.counterQue.Enqueue(new int[2] { targetNO, testNO });

            bool result = testObj.Equal2Times(targetNO, testNO);

            Assert.AreEqual(result, true);      //will be error
        }
    }
}
