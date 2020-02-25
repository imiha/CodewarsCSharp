using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Persist
    {
        public static int Persistence(long n)
        {
            if (n < 10) return 0;
            return 1 + Persistence(("" + n).Select(x => long.Parse(x.ToString())).Aggregate((acc, x) => acc * x));
        }

        public static int Persistence_Chris_fqs(long n)
        {
            int i = 0;
            string s;
            while ((s = n.ToString()).Length > 1)
            {
                n = s.Select(c => c - '0').Aggregate((a, b) => a * b);
                i++;
            }
            return i;
        }

        public static int Persistence_Brutus9(long n)
        {
            // your code
            var count = 0;
            while (n > 9)
            {
                double items = 1.0;
                foreach (var numb in n.ToString().ToCharArray())
                {
                    items = items * Char.GetNumericValue(numb);
                }
                n = (long)items;
                count++;
            }
            return count;
        }
    }
}
