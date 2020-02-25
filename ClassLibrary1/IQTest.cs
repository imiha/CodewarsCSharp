using BenchmarkDotNet.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class IQTest
    {
        [Benchmark]
        public static int Solve(string numbers)
        {            
            var a = numbers.Split(" ").Select(x => Convert.ToInt32(x) % 2);
            var b = a.GroupBy(x => x).FirstOrDefault(x => x.Count() == 1)?.Key;
            return b.HasValue ? a.ToList().IndexOf(b.Value) + 1 : 0;
        }
        [Benchmark]
        public static int Solve_Equim(string numbers)
        {
            List<int> n = Array.ConvertAll(numbers.Split(' '), s => int.Parse(s)).ToList();
            return n.Count(p => p % 2 == 0) == 1 ? n.FindIndex(u => u % 2 == 0) + 1 : n.FindIndex(u => u % 2 == 1) + 1;
        }
        [Benchmark]
        public static int Solve_samranjbari(string numbers)
        {
            return numbers.Split(' ')
            .Select((v, i) => new { numbers = v, index = i })
            .GroupBy(g => Convert.ToInt32(g.numbers) % 2)
            .First(w => w.Count() == 1)
            .Select(s => s.index).First() + 1;
        }
        [Benchmark]
        public static int Solve_Chris(string numbers)
            => numbers
                .Split(' ')
                .Select((number, position) => new
                {
                    Even = int.Parse(number) % 2 == 0,
                    Position = position + 1
                })
                .GroupBy(number => number.Even)
                .OrderBy(group => group.Count())
                .ThenByDescending(group => group.Min(rec => rec.Position))
                .First()
                .Min(group => group.Position);
    }
}
