using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 13;
            var s = "aaaaabbbbaaaa";

            var ps = new PalindromSum();
            var res = ps.GetPolindromLength(s, n);

            var tmp = res[res.Count - 1];

            res = res.Take(res.Count - 1).ToList();
            res.Insert(0, tmp);

            foreach (var re in res)
            {
                Console.WriteLine(re);
            }

            Console.ReadLine();
        }

        
    }
}
