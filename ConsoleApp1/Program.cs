using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;
using ClassLibrary1;

namespace ConsoleApp1
{
    // https://www.codewars.com/kata/552c028c030765286c00007d/train/csharp
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(IQTest.Solve("1 3 5 4 7 9 11"));
            //Console.WriteLine(IQTest.Solve("1 0 2 4"));
            //Console.WriteLine(IQTest.Solve("1 2 3"));
            //Console.WriteLine(IQTest.Solve("1 3 4"));
            //Console.WriteLine(IQTest.Solve("1 3 5 7"));

            // Console.WriteLine(SpinWords.Solve("Hey world!"));

            var summary = BenchmarkRunner.Run<IQTest>();
            Console.ReadLine();
        }

        [MemoryDiagnoser]
        [Orderer(SummaryOrderPolicy.FastestToSlowest, MethodOrderPolicy.Declared)]
        public class IQTest
        {
            [Params
            (
                "1 2 2",
                "9 31 27 93 17 77 75 9 9 53 89 39 51 99 5 1 11 39 27 49 91 17 27 79 81 71 37 75 35 13 93 4 99 55 85 11 23 57 5 43 5 61 15 35 23 91 3 81 99 85 43 37 39 27 5 67 7 33 75 59 13 71 51 27 15 93 51 63 91 53 43 99 25 47 17 71 81 15 53 31 59 83 41 23 73 25 91 9"
            )]
            public string Input;

            [Benchmark]
            public int Richard()
            {
                var intList = Input.Split(' ').Select(n => int.Parse(n) % 2 == 0).ToList();
                return intList.IndexOf(intList.GroupBy(b => b).OrderBy(grp => grp.Count()).Select(grp => grp.Key).First()) + 1;
            }

            [Benchmark]
            public int Brian()
            {
                var numbs = Input.Split(" ").Select(x => int.Parse(x) % 2 == 0).ToArray();
                var key = numbs.GroupBy(x => x).OrderByDescending(g => g.Count()).Last().Key;
                return Array.FindIndex(numbs, row => row == key) + 1;
            }


            [Benchmark]
            public int Alexander()
            {
                var x1 = Input.Split(" ").Select(x => Convert.ToInt32(x)).Select(x => x % 2);
                return Array.IndexOf(x1.ToArray(), x1.GroupBy(x => x, x => x).First(x => x.Count() == 1).Key) + 1;
            }

            [Benchmark]
            public int Ruud()
            {
                var grouped = Input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select((value, index) => new { Mod = int.Parse(value) % 2, Index = index })
                    .GroupBy(m => m.Mod)
                    .OrderBy(m => m.Count());

                if (grouped.Count() > 1)
                {
                    return grouped.First().First().Index + 1;
                }
                else
                {
                    return 0;
                }
            }

            [Benchmark]
            public int Sean()
            {
                return GetIndexOfOddNumber(Input.Split(' '));
            }

            public static int GetIndexOfOddNumber(string[] array)
            {
                if (array.Length == 1)
                    return 0;

                for (var index = 1; index < array.Length; index++)
                {
                    var modPrev = array[index - 1].Last() & 1;
                    var modCurr = array[index].Last() & 1;

                    if (modPrev != modCurr)
                    {
                        if (index + 1 < array.Length && modCurr == (array[index + 1].Last() & 1))
                            return index;

                        return index + 1;
                    }
                }

                return 0;
            }

            [Benchmark]
            public int Mihaela()
            {
                var a = Input.Split(" ").Select(x => Convert.ToInt32(x) % 2);
                var b = a.GroupBy(x => x).FirstOrDefault(x => x.Count() == 1)?.Key;
                return b.HasValue ? a.ToList().IndexOf(b.Value) + 1 : 0;
            }

            [Benchmark]
            /// <summary>
            /// Assumes that numbers are seperated by 1 space and are all valid integers
            /// </summary>
            public int Chris()
                => Input
                    .Split(' ')
                    .Select((number, position) => new
                    {
                        Even = int.Parse(number) % 2,
                        Position = position + 1
                    })
                    .GroupBy(number => number.Even)
                    .OrderBy(group => group.Count())
                    .ThenByDescending(group => group.Min(rec => rec.Position)) //when the number of even and uneven ranges are equal, regard the second occurrence as the annomaly.
                    .First()
                    .Min(group => group.Position);

            [Benchmark]
            public int SupposedlyFast()
            {
                List<int> n = Array.ConvertAll(Input.Split(' '), s => int.Parse(s)).ToList();
                return n.Count(p => p % 2 == 0) == 1 ? n.FindIndex(u => u % 2 == 0) + 1 : n.FindIndex(u => u % 2 == 1) + 1;
            }

        }
    }
}
