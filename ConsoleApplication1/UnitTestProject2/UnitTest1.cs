using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsOdd()
        {
            bool result3 = Program.IsOdd(3);
            Assert.AreEqual(true, result3);

            bool result4 = Program.IsOdd(4);
            Assert.AreEqual(false, result4);          
        }
        [TestMethod]
        public void TestAbs()
        {
             int result6 = Program.Abs(-6);
             Assert.AreEqual(6,result6);
        }
        [TestMethod]
        public void TestCeil()
        {
            int rs = Program.Ceil(4.6F);
            Assert.AreEqual(5, rs);

            int rs1 = Program.Ceil(-2.3F);
            Assert.AreEqual(-2, rs1);

            int rs2 = Program.Ceil(3);
            Assert.AreEqual(3, rs2);

        }
        [TestMethod]
        public void TestFloor()
        {
            int rs = Program.Floor(7.7F);
            Assert.AreEqual(7, rs);
        }
        [TestMethod]
        public void TestCube()
        {
            int rs = Program.Cube(-10);
            Assert.AreEqual(-1000, rs);
        }
        [TestMethod]
        public void TestIsEven()
        {
            bool rs = Program.IsEven(4);
            Assert.AreEqual(true, rs);
        }
        [TestMethod]
        public void TestIsPrime()
        {
            bool rs = Program.IsPrime(7);
            Assert.AreEqual(true, rs);
        }
        [TestMethod]
        public void TestPow()
        {
            int rs = Program.Pow(2,3);
            Assert.AreEqual(8, rs);
        }
        [TestMethod]
        public void TestSquare()
        {
            int rs = Program.Square(4);
            Assert.AreEqual(16, rs);
        }
        [TestMethod]
        public void TestFactorial()
        {
            long rs = Program.Factorial(20L);
            Assert.AreEqual(109641728, rs);
        }
        
    }
}
