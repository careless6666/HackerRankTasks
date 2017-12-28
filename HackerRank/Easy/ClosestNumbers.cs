using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Easy
{
    public class ClosestNumbers
    {
        public static List<int> GetClosest(int[] a)
        {
            var l = a.ToList();
            l.Sort();

            var min = int.MaxValue;

            var minList = new List<int>();

            for (var i = 0; i < l.Count - 1; i++)
            {
                var val = l.ElementAt(i) - l.ElementAt(i + 1);
                if (Math.Abs(val) <= min)
                    min = Math.Abs(val);
            }

            for (var i = 0; i < l.Count - 1; i++)
            {
                var val = l.ElementAt(i) - l.ElementAt(i + 1);
                if (Math.Abs(val) == min)
                {
                    minList.Add(l.ElementAt(i));
                    minList.Add(l.ElementAt(i + 1));
                }
            }

            return minList;
        }
    }
}
