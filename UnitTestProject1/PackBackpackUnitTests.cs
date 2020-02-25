using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class PackBackpackUnitTests
    {
        [TestMethod]
        public void Test1()
        {
            //Assert.AreEqual(29, PackBackpack.Solve(new int[] { 15, 10, 9, 5 }, new int[] { 1, 5, 3, 4 }, 8));
            //Assert.AreEqual(11, PackBackpack.Solve(new int[] { 10, 6, 5 }, new int[] { 3, 2, 2 }, 4));
            Assert.AreEqual(29, PackBackpack.Solve_hurlyz(new int[] { 15, 10, 9, 5 }, new int[] { 1, 5, 3, 4 }, 8));
        }
        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(60, PackBackpack.Solve(new int[] { 20, 5, 10, 40, 15, 25 }, new int[] { 1, 2, 3, 8, 7, 4 }, 10));
        }
    }
}
