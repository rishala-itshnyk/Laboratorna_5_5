using System;
using System.IO;
using NUnit.Framework;

namespace Program.Tests
{
    [TestFixture]
    public class Tests
    {
        int resSys = 2;
        int number = 20;

        [Test]
        public void TestTenBase()
        {
            string actual = Program.TenBase(number, resSys);

            Assert.AreEqual("10100", actual);
        }

        [Test]
        public void TestF()
        {
            int depth = 0;

            int result = Program.F(number, resSys,1, ref depth);

            Assert.AreEqual(1, result);
            Assert.AreEqual(4, depth);
        }
    }
}