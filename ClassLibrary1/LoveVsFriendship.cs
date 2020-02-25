using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class LoveVsFriendship
    {
        public static int WordsToMarks(string str)
        {
            return str.Select(x => (int)x - (int)'a' + 1).Aggregate(0, (acc, x) => acc + x);
        }
    }
}
