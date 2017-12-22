using System;
using System.Linq;
using HackerRank.Hard;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            var divider = 7;
            var repeat = 1;
            var a = new long[] {3, 3, 9, 9, 5};

            for(var i = 0; i < repeat; i++)
                Repeat(divider, a);

            Console.WriteLine(MaximumSubarraySum.GetMax());


            Console.ReadLine();
        }


        private static void Repeat(long divider, long[] a)
        {
            for (int i = 0; i <= a.Length; i++)
                MaximumSubarraySum.CalcMax(a, i, divider);
        }
        
    }
}
