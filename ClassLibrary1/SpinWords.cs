using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public static class SpinWords
    {
        public static string Solve(string sentence)
        {
            return string.Join(' ', sentence.Split(' ').Select(x => x.Length >= 5 ? new string(x.Reverse().ToArray()) : x));
        }
    }
}
