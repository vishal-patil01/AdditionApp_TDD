using AdditionApp;
using NUnit.Framework;

namespace AdditionAppTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int result = Addition.sum(5, 5);
            Assert.AreEqual(result, 10);
        }
    }
}