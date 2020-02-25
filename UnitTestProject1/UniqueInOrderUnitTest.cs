using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ClassLibrary1;
using System;
using System.Linq;
using System.Collections;

namespace UnitTestProject1
{
    [TestClass]
    public class UniqueInOrderUnitTest
    {
        [TestMethod]
        public void UniqueInOrder_Miha()
        {
            IEnumerable expected = "";
            IEnumerable actual = UniqueInOrder.Solve("");
            Assert.IsTrue(((IEnumerable<char>)actual).SequenceEqual((IEnumerable<char>)expected));

            expected = new List<char> { 'A', 'B', 'C', 'D', 'A', 'B' };
            actual = UniqueInOrder.Solve("AAAABBBCCDAABBB");            
            Assert.IsTrue(((IEnumerable<char>)actual).SequenceEqual((IEnumerable<char>)expected));

            expected = new List<char> { 'A', 'B', 'C', 'c', 'A', 'D' };
            actual = UniqueInOrder.Solve("ABBCcAD");
            Assert.IsTrue(((IEnumerable<char>)actual).SequenceEqual((IEnumerable<char>)expected));

            expected = new List<int> { 1, 2, 3 };
            actual = UniqueInOrder.Solve(new int[] { 1, 2, 2, 3, 3 });
            Assert.IsTrue(((IEnumerable<int>)actual).SequenceEqual((IEnumerable<int>)expected));

            expected = new List<int> { 0, 1, 2, 3 };
            actual = UniqueInOrder.Solve(new int[] { 0, 1, 2, 2, 3, 3 });
            Assert.IsTrue(((IEnumerable<int>)actual).SequenceEqual((IEnumerable<int>)expected));
        }

        [TestMethod]
        public void UniqueInOrder_Magyart()
        {
            IEnumerable expected = "";
            IEnumerable actual = UniqueInOrder.Solve_Magyart("");
            Assert.IsTrue(((IEnumerable<char>)actual).SequenceEqual((IEnumerable<char>)expected));

            expected = new List<char> { 'A', 'B', 'C', 'D', 'A', 'B' };
            actual = UniqueInOrder.Solve_Magyart("AAAABBBCCDAABBB");
            Assert.IsTrue(((IEnumerable<char>)actual).SequenceEqual((IEnumerable<char>)expected));

            expected = new List<char> { 'A', 'B', 'C', 'D', 'A', 'B' };
            actual = UniqueInOrder.Solve_Magyart("AAAABBBCCDAABBB");
            Assert.IsTrue(((IEnumerable<char>)actual).SequenceEqual((IEnumerable<char>)expected));

            expected = new List<int> { 1, 2, 3 };
            actual = UniqueInOrder.Solve_Magyart(new int[] { 1, 2, 2, 3, 3 });
            Assert.IsTrue(((IEnumerable<int>)actual).SequenceEqual((IEnumerable<int>)expected));

            expected = new List<int> { 0, 1, 2, 3 };
            actual = UniqueInOrder.Solve_Magyart(new int[] { 0, 1, 2, 2, 3, 3 });
            Assert.IsTrue(((IEnumerable<int>)actual).SequenceEqual((IEnumerable<int>)expected));
        }

        [TestMethod]
        public void UniqueInOrder_Gibus043()
        {
            IEnumerable expected = "";
            IEnumerable actual = UniqueInOrder.Solve_Gibus043("");
            Assert.IsTrue(((IEnumerable<char>)actual).SequenceEqual((IEnumerable<char>)expected));

            expected = new List<char> { 'A', 'B', 'C', 'D', 'A', 'B' };
            actual = UniqueInOrder.Solve_Gibus043("AAAABBBCCDAABBB");
            Assert.IsTrue(((IEnumerable<char>)actual).SequenceEqual((IEnumerable<char>)expected));

            expected = new List<char> { 'A', 'B', 'C', 'D', 'A', 'B' };
            actual = UniqueInOrder.Solve_Gibus043("AAAABBBCCDAABBB");
            Assert.IsTrue(((IEnumerable<char>)actual).SequenceEqual((IEnumerable<char>)expected));

            expected = new List<int> { 1, 2, 3 };
            actual = UniqueInOrder.Solve_Gibus043(new int[] { 1, 2, 2, 3, 3 });
            Assert.IsTrue(((IEnumerable<int>)actual).SequenceEqual((IEnumerable<int>)expected));

            expected = new List<int> { 0, 1, 2, 3 };
            actual = UniqueInOrder.Solve_Gibus043(new int[] { 0, 1, 2, 2, 3, 3 });
            Assert.IsTrue(((IEnumerable<int>)actual).SequenceEqual((IEnumerable<int>)expected));
        }
    }
}
