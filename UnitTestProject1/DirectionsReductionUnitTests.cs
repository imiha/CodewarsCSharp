using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class DirectionsReductionUnitTests
    {
        [TestMethod]
        public void Test1()
        {
            string[] a = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
            string[] b = new string[] { "WEST" };
            //var m = DirectionsReduction.Solve(a);
            //var m = DirectionsReduction.Solve_myjinxin2015(a);
            var m = DirectionsReduction.Solve_Chris_fqs(a);
            CollectionAssert.AreEqual(b, m);
        }
        [TestMethod]
        public void Test2()
        {
            string[] a = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
            string[] b = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
            //var m = DirectionsReduction.Solve(a);
            //var m = DirectionsReduction.Solve_myjinxin2015(a);
            var m = DirectionsReduction.Solve_Chris_fqs(a);
            CollectionAssert.AreEqual(b, m);
        }
    }
}
