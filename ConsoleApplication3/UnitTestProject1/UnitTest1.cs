using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication3;
using System.IO;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCeil()
        {
            int result1 = Program.Ceil((float)2.3);
            Assert.AreEqual(3, result1);

            int rs2 = Program.Ceil((float)-2.3f);
            Assert.AreEqual(-2, rs2);

            int rs3 = Program.Ceil(3);
            Assert.AreEqual(3, rs3);

        }
        [TestMethod]
        public void TestFloor()
        {
            int result2 = Program.Floor((float)2.3);
            Assert.AreEqual(2, result2);

            int rs3 = Program.Floor((float)-2.3f);
            Assert.AreEqual(-3, rs3);

            int rs4 = Program.Floor(3);
            Assert.AreEqual(3, rs4);
        }

    }

}
