using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class UniqueInOrder
    {
        public static IEnumerable<T> Solve<T>(IEnumerable<T> iterable)
        {
            return iterable.Aggregate(new List<T>(), (acc, x) =>
            {
                if(acc.Count == 0 || !x.Equals(acc.Last()))
                {
                    acc.Add(x);
                }                

                return acc;
            });
        }

        public static IEnumerable<T> Solve_Magyart<T>(IEnumerable<T> iterable)
        {
            T previous = default;
            int i = 0;
            foreach (T current in iterable)
            {
                if (i == 0)
                {
                    yield  return current;
                }
                else if (!current.Equals(previous))
                {
                    yield return current;
                }
                previous = current;
                i++;
            }
        }

        public static IEnumerable<T> Solve_Gibus043<T>(IEnumerable<T> iterable)
        {
            return iterable.Where((x, i) => i == 0 || !Equals(x, iterable.ElementAt(i - 1)));
        }
    }
}
