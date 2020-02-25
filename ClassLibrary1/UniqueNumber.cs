using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public static class UniqueNumber
    {
        public static int Solve(IEnumerable<int> numbers)
        {
            return numbers.ToList().GroupBy(x => x).First(g => g.Count() == 1).Key;
        }

        public static int Solve_Seeken(IEnumerable<int> numbers)
        {
            List<int> numbersList = numbers.ToList();
            numbersList.Sort();
            if (numbersList[0] != numbersList[1])
            {
                return numbersList[0];
            }
            return numbersList[numbersList.Count - 1];
        }

        public static int Solve_Blune(IEnumerable<int> numbers) => numbers.GroupBy(x => x).First(y => y.Count() == 1).First();
    }
}
