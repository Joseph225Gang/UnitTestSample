using NUnit.Framework;
using UnitTestSample.Model;

namespace UnitTest
{
    [TestFixture()]
    public class ExampleTest
    {
        [Test()]
        [TestCase("abc", "cba")]
        [TestCase("marcus", "sucram")]
        [TestCase("apple", "elppa")]
        public void MultiReverseTest(string input, string output)
        {
            var ex = new Example();
            var actual = ex.Reverse(input);
            Assert.AreEqual(output, actual);
        }
    }
}