using System;
using ConsoleApplication1;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestAdd()
        {
            Assert.AreEqual(Program.add(5, 12), 5+12);
        }

        [Test]
        public void TestDivide()
        {
            Assert.AreEqual(Program.divide(5, 12), 5/12 );

            //AssertFailedException.Equals(Program.divide(5, 0), );
        }
    }
}
