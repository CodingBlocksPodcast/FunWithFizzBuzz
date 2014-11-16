using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace FizzBuzz.Test
{
    [TestClass]
    public class FizzBuzzTest
    {
        [DeploymentItem(@"ExpectedOutput.txt")]
        public void Test<T>() where T : IFizzBuzzStrategy, new()
        {
            var target = new T();
            var actual = target.Execute();
            var expected = File.ReadAllText("ExpectedOutput.txt");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ChainOfResponsibilityTest()
        {
            Test<FizzBuzzChainOfResponsibility>();
        }

        [TestMethod]
        public void IteratorTest()
        {
            Test<FizzBuzzIterator>();
        }

        [TestMethod]
        public void RecursiveTest()
        {
            Test<FizzBuzzRecursive>();
        }

        [TestMethod]
        public void StandardTest()
        {
            Test<FizzBuzzStandard>();
        }
    }
}
