using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace UnitTestProject1
{
    [TestClass]
    public class IQTestUnitTest
    {
        [TestMethod]
        public void A()
        {
            var stopWatch = Stopwatch.StartNew();
            Assert.AreEqual("emocleW", SpinWords.Solve("Welcome"));
            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedTicks.ToString());
        }

        [TestMethod]
        public void IQTest_A_Miha()
        {
            var stopWatch = Stopwatch.StartNew();
            Assert.AreEqual(32, IQTest.Solve("9 31 27 93 17 77 75 9 9 53 89 39 51 99 5 1 11 39 27 49 91 17 27 79 81 71 37 75 35 13 93 4 99 55 85 11 23 57 5 43 5 61 15 35 23 91 3 81 99 85 43 37 39 27 5 67 7 33 75 59 13 71 51 27 15 93 51 63 91 53 43 99 25 47 17 71 81 15 53 31 59 83 41 23 73 25 91 9"));
            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedTicks.ToString());
        }


        [TestMethod]
        public void IQTest_A_Equim()
        {
            var stopWatch = Stopwatch.StartNew();
            Assert.AreEqual(32, IQTest.Solve_Equim("9 31 27 93 17 77 75 9 9 53 89 39 51 99 5 1 11 39 27 49 91 17 27 79 81 71 37 75 35 13 93 4 99 55 85 11 23 57 5 43 5 61 15 35 23 91 3 81 99 85 43 37 39 27 5 67 7 33 75 59 13 71 51 27 15 93 51 63 91 53 43 99 25 47 17 71 81 15 53 31 59 83 41 23 73 25 91 9"));
            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedTicks.ToString());
        }


        [TestMethod]
        public void IQTest_A_samranjbari()
        {
            var stopWatch = Stopwatch.StartNew();
            Assert.AreEqual(32, IQTest.Solve_samranjbari("9 31 27 93 17 77 75 9 9 53 89 39 51 99 5 1 11 39 27 49 91 17 27 79 81 71 37 75 35 13 93 4 99 55 85 11 23 57 5 43 5 61 15 35 23 91 3 81 99 85 43 37 39 27 5 67 7 33 75 59 13 71 51 27 15 93 51 63 91 53 43 99 25 47 17 71 81 15 53 31 59 83 41 23 73 25 91 9"));
            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedTicks.ToString());
        }


        [TestMethod]
        public void IQTest_A_Chris()
        {
            var stopWatch = Stopwatch.StartNew();
            Assert.AreEqual(32, IQTest.Solve_Chris("9 31 27 93 17 77 75 9 9 53 89 39 51 99 5 1 11 39 27 49 91 17 27 79 81 71 37 75 35 13 93 4 99 55 85 11 23 57 5 43 5 61 15 35 23 91 3 81 99 85 43 37 39 27 5 67 7 33 75 59 13 71 51 27 15 93 51 63 91 53 43 99 25 47 17 71 81 15 53 31 59 83 41 23 73 25 91 9"));
            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedTicks.ToString());
        }

        [TestMethod]
        public void IQTest_Miha()
        {
            var stopWatch = Stopwatch.StartNew();
            //Assert.AreEqual(4, IQTest.Solve("1 3 5 4 7 9 11"));
            //Assert.AreEqual(1, IQTest.Solve("1 0 2 4"));
            //Assert.AreEqual(2, IQTest.Solve("1 2 3"));
            //Assert.AreEqual(3, IQTest.Solve("1 3 4"));
            //Assert.AreEqual(0, IQTest.Solve("1 3 5 7"));

            Assert.AreEqual(32, IQTest.Solve("9 31 27 93 17 77 75 9 9 53 89 39 51 99 5 1 11 39 27 49 91 17 27 79 81 71 37 75 35 13 93 4 99 55 85 11 23 57 5 43 5 61 15 35 23 91 3 81 99 85 43 37 39 27 5 67 7 33 75 59 13 71 51 27 15 93 51 63 91 53 43 99 25 47 17 71 81 15 53 31 59 83 41 23 73 25 91 9"));

            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedTicks.ToString());
        }

        [TestMethod]
        public void IQTest_Equim()
        {
            var stopWatch = Stopwatch.StartNew();
            //Assert.AreEqual(4, IQTest.Solve_Equim("1 3 5 4 7 9 11"));
            //Assert.AreEqual(1, IQTest.Solve_Equim("1 0 2 4"));
            //Assert.AreEqual(2, IQTest.Solve_Equim("1 2 3"));
            //Assert.AreEqual(3, IQTest.Solve_Equim("1 3 4"));
            Assert.AreEqual(32, IQTest.Solve_Equim("9 31 27 93 17 77 75 9 9 53 89 39 51 99 5 1 11 39 27 49 91 17 27 79 81 71 37 75 35 13 93 4 99 55 85 11 23 57 5 43 5 61 15 35 23 91 3 81 99 85 43 37 39 27 5 67 7 33 75 59 13 71 51 27 15 93 51 63 91 53 43 99 25 47 17 71 81 15 53 31 59 83 41 23 73 25 91 9"));
            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedTicks.ToString());
        }

        [TestMethod]
        public void IQTest_samranjbari()
        {
            var stopWatch = Stopwatch.StartNew();
            //    Assert.AreEqual(4, IQTest.Solve_samranjbari("1 3 5 4 7 9 11"));
            //    Assert.AreEqual(1, IQTest.Solve_samranjbari("1 0 2 4"));
            //    Assert.AreEqual(2, IQTest.Solve_samranjbari("1 2 3"));
            //    Assert.AreEqual(3, IQTest.Solve_samranjbari("1 3 4"));
            Assert.AreEqual(32, IQTest.Solve_samranjbari("9 31 27 93 17 77 75 9 9 53 89 39 51 99 5 1 11 39 27 49 91 17 27 79 81 71 37 75 35 13 93 4 99 55 85 11 23 57 5 43 5 61 15 35 23 91 3 81 99 85 43 37 39 27 5 67 7 33 75 59 13 71 51 27 15 93 51 63 91 53 43 99 25 47 17 71 81 15 53 31 59 83 41 23 73 25 91 9"));
            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedTicks.ToString());
        }

        [TestMethod]
        public void IQTest_wChris()
        {
            var stopWatch = Stopwatch.StartNew();
            Assert.AreEqual(32, IQTest.Solve_Chris("9 31 27 93 17 77 75 9 9 53 89 39 51 99 5 1 11 39 27 49 91 17 27 79 81 71 37 75 35 13 93 4 99 55 85 11 23 57 5 43 5 61 15 35 23 91 3 81 99 85 43 37 39 27 5 67 7 33 75 59 13 71 51 27 15 93 51 63 91 53 43 99 25 47 17 71 81 15 53 31 59 83 41 23 73 25 91 9"));
            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedTicks.ToString());
        }
    }
}
