using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            Assert.AreEqual(Program.add(5, 12), 17);
        }

        [TestMethod]
        public void TestDivide()
        {
            Assert.AreEqual(Program.divide(5, 12), 0 );
        }
    }
}
