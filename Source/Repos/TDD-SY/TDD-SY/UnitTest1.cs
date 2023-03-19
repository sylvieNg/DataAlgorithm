using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TDD_SY
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MathComponent obj = new MathComponent();
            int result = obj.Add(10, 10);
            Assert.AreEqual(20, result);
        }
    }
}
