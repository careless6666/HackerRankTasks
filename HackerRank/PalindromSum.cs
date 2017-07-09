using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class PalindromSum
    {
        public List<int> GetPolindromLength(string s, int n)
        {
            var res = new List<int>();

            for (int i = 0; i < n; i++)
            {
                s = s.Substring(1) + s[0];
                var length = LongestPalindrome(s);
                res.Add(length);
            }

            return res;
        }

        public static int LongestPalindrome(string seq)
        {
            int longest = 0;
            var l = new List<int>();
            int i = 0;
            int palLen = 0;
            int s = 0;
            int e = 0;
            while (i < seq.Length)
            {
                if (i > palLen && seq[i - palLen - 1] == seq[i])
                {
                    palLen += 2;
                    i += 1;
                    continue;
                }
                l.Add(palLen);
                longest = Math.Max(longest, palLen);
                s = l.Count - 2;
                e = s - palLen;
                bool found = false;
                for (int j = s; j > e; j--)
                {
                    int d = j - e - 1;
                    if (l[j] == d)
                    {
                        palLen = d;
                        found = true;
                        break;
                    }
                    l.Add(Math.Min(d, l[j]));
                }
                if (!found)
                {
                    palLen = 1;
                    i += 1;
                }
            }
            l.Add(palLen);
            longest = Math.Max(longest, palLen);
            return longest;
        }
    }
}
