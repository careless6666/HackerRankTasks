using System;
using System.Collections.Generic;

namespace HackerRank.Hard
{
    //https://www.hackerrank.com/challenges/maximum-subarray-sum/problem

    public class MaximumSubarraySum
    {
        private static long _max;

        public static long CalcMax(long[] a, long m, long devider)
        {
            printCombination(a, a.Length, m, devider);

            return _max;
        }

        public static long GetMax() => _max;

        static void printCombination(long[] arr, long n, long r, long devider)
        {
            // A temporary array to store all combination one by one
            var data = new long[r];

            // Print all combination using temprary array 'data[]'
            combinationUtil(arr, data, 0, n - 1, 0, r, devider);
        }

        /* arr[]  ---> Input Array
           data[] ---> Temporary array to store current combination
           start & end ---> Staring and Ending indexes in arr[]
           index  ---> Current index in data[]
           r ---> Size of a combination to be prlonged */
        static void combinationUtil(long[] arr, long[] data, long start, long end,
        long index, long r, long devider)
        {
            // Current combination is ready to be prlonged, print it
            if (index == r)
            {
                long sum = 0;
                for (long j = 0; j < r; j++)
                {
                    Console.Write(data[j] + " ");
                    sum += data[j];
                }

                if (_max < sum % devider)
                    _max = sum % devider;

                sum = 0;

                    Console.WriteLine();
                return;
            }

            // replace index with all possible elements. The condition
            // "end-i+1 >= r-index" makes sure that including one element
            // at index will make a combination with remaining elements
            // at remaining positions
            for (long i = start; i <= end && end - i + 1 >= r - index; i++)
            {
                data[index] = arr[i];
                combinationUtil(arr, data, i + 1, end, index + 1, r, devider);
            }
        }
    }
}
