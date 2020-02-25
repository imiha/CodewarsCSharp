using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UniqueNumberUnitTest
    {
        [TestMethod]
        public void UniqueNumber_Miha()
        {
            Assert.AreEqual(2, UniqueNumber.Solve(new int[] { 1, 1, 1, 2, 1, 1 }));
        }

        [TestMethod]
        public void UniqueNumber_Seeken()
        {
            Assert.AreEqual(2, UniqueNumber.Solve_Seeken(new int[] { 1, 1, 1, 2, 1, 1 }));
        }

        [TestMethod]
        public void UniqueNumber_Blune()
        {
            Assert.AreEqual(2, UniqueNumber.Solve_Blune(new int[] { 1, 1, 1, 2, 1, 1 }));
        }
    }
}
