using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Medium
{
    //https://www.hackerrank.com/challenges/pairs/problem
    public class PairsWithDiff
    {
        public static int Get(int[] a, int k)
        {
            var counter = 0;

            for (var i = 0; i < a.Length; i++)
            {
                for (var j = i + 1; j < a.Length; j++)
                {
                    if (Math.Abs(a[i] - a[j]) == k)
                        counter++;
                }
            }
            return counter;
        }
    }
}
