using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberGeneratorProcessor;
using System.Collections.Generic;

namespace UnitTestNumbers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<int> generatedNo = new Processor().GenerateNumber(10);

            Assert.IsNotNull(generatedNo);
            Assert.IsTrue(generatedNo.Count == 11);

        }

        [TestMethod]
        public void TestDevideNumber()
        {
            string generatedNo = new Processor().GetValues(3,3);

            Assert.IsNotNull(generatedNo);

        }
    }
}
