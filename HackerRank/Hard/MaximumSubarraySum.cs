using System;
using System.Collections.Generic;

namespace HackerRank.Hard
{
    //https://www.hackerrank.com/challenges/maximum-subarray-sum/problem

    public class MaximumSubarraySum
    {
        private static long _max;

        public static long CalcMax(long[] a, long devider)
        {
            for (var i = 0; i < a.Length; i++)
            {
                long sum = a[i];

                CheckMax(devider, sum);

                for (var j = i; j < a.Length; j++)
                {
                    sum += a[j];
                    CheckMax(devider, sum);
                }
                if (_max == devider - 1)
                    return _max;
            }

            return _max;
        }

        private static void CheckMax(long devider, long sum)
        {
            var tmpTes = sum % devider;

            if (tmpTes > _max)
                _max = tmpTes;
        }

        public static long GetMax() => _max;
    }
}
