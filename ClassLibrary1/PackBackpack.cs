using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ClassLibrary1
{
    public class PackBackpack
    {
        static int[] weights;
        static int[] scores;
        static int[,] results;
        
        public static int Solve(int[] scores, int[] weights, int capacity)
        {
            PackBackpack.weights = weights;
            PackBackpack.scores = scores;
            results = new int[capacity + 1, weights.Length];

            int result = GetOptimum(capacity, 0);
            return result;
        }

        private static int GetOptimum(int capacity, int i)
        {
            int z;
            if (i > weights.Length - 1)
            {
                return 0;
            }

            z = results[capacity, i];
            if (z != 0)
            {
                return z;
            }

            if (capacity < weights[i])
            {
                // no, dont take it              
                return z != 0 ? z : GetOptimum(capacity, i + 1);
            }

            //yes, take it            
            int r_yes = z != 0 ? z : GetOptimum(capacity - weights[i], i + 1) + scores[i];

            //no, dont take it            
            int r_no = z != 0 ? z : GetOptimum(capacity, i + 1);
            var result = Math.Max(r_no, r_yes);
            results[capacity, i] = result;
            return result;
        }

        public static int Solve_hurlyz(int[] scores, int[] weights, int capacity)
        {
            Array.Sort(scores, weights);
            int[,] bag = new int[scores.Length + 1, capacity + 1];

            for (int i = 0; i < scores.Length; i++)
            {
                for (int j = 1; j <= capacity; j++)
                {
                    bag[i + 1, j] = weights[i] <= j ? Math.Max(scores[i] + bag[i, j - weights[i]], bag[i, j]) : bag[i, j];
                }
            }

            return bag[scores.Length, capacity];
        }

        //===========================================
        public static int Solve_greedy_wrong(int[] scores, int[] weights, int capacity)
        {
            //Assert.AreEqual(29, PackBackpack.Solve(new int[] { 15, 10, 9, 5 }, new int[] { 1, 5, 3, 4 }, 8));
            //Assert.AreEqual(60, Packer.PackBagpack(new int[] {20, 5, 10, 40, 15, 25}, new int[] {1, 2, 3, 8, 7, 4}, 10));


            var m = scores.Select((x, i) => Tuple.Create(x / (float)weights[i], i)).ToArray();
            Array.Sort(m, (a, b) => b.Item1.CompareTo(a.Item1));

            int w = 0;
            int result = 0;
            for (int i = 0; i < m.Length; i++)
            {
                if (w + weights[m[i].Item2] <= capacity)
                {
                    w += weights[m[i].Item2];
                    result += scores[m[i].Item2];
                }
            }

            return result;
        }
    }

    
}
