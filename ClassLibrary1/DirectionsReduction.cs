using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ClassLibrary1
{
    public class DirectionsReduction
    {
        public static string[] Solve(String[] arr)
        {
            //  ["NORTH", "EAST", "WEST", "SOUTH", "WEST", "WEST"]
            var ns = new List<string> { "NORTH", "SOUTH" };
            var ew = new List<string> { "EAST", "WEST" };

            var result = arr.Aggregate(new List<string>(), (acc, x) =>
            {
                var lastAccIndex = acc.Count - 1;
                if (acc.Count != 0 && x != acc[lastAccIndex] && (ns.Contains(x) && ns.Contains(acc[lastAccIndex]) || ew.Contains(x) && ew.Contains(acc[lastAccIndex])))
                {
                    acc.RemoveAt(lastAccIndex);
                }
                else
                {
                    acc.Add(x);
                }
                return acc;
            });
            return result.ToArray();
        }

        public static string[] Solve_myjinxin2015(String[] arr)
        {
            string s = new string(arr.Select(x => x[0]).ToArray());
            while (Regex.Match(s, "NS|EW|SN|WE").Success) s = Regex.Replace(s, "NS|EW|SN|WE", "");
            return s.Select(x => x == 'N' ? "NORTH" : x == 'S' ? "SOUTH" : x == 'E' ? "EAST" : "WEST").ToArray();
        }

        public static string[] Solve_Chris_fqs(String[] arr)
        {
            var result = new Stack<string>();
            var diffs = new[] { Math.Abs('N' - 'S'), Math.Abs('W' - 'E') };
            foreach (var item in arr)
            {
                if (result.TryPeek(out string current) && diffs.Contains(Math.Abs(current[0] - item[0])))
                    result.Pop();
                else
                    result.Push(item);
            }
            return result.Reverse().ToArray();
        }
    }
}
