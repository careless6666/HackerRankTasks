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

            Array.Sort(a);

            for (var i = 0; i < a.Length; i++)
            {
                for (var j = i + 1; j < a.Length; j++)
                {
                    if (a[i] + k == a[j])
                    {
                        counter++;
                        break;
                    } else if (a[j] - a[i] > k)
                    {
                        break;
                    }
                }
                    
            }
            return counter;
        }
    }
}
