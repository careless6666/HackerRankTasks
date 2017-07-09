using System;
using System.Collections.Generic;

namespace HackerRank
{
    public class MaxPalindrom
    {
        public int[] GetPolindromLength(string s, int n)
        {
            var res = new int[n];

            for (int i = 0; i < n; i++)
            {
                s = s.Substring(1) + s[0];
                var length = LongestPalindrome(s);
                if (i == n-1)
                    res[0] = length;
                else
                    res[i+1] = length;
            }

            return res;
        }

        private static int LongestPalindrome(string seq)
        {
            int longest = 0, i = 0, palLen = 0;
            var l = new List<int>();
            
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
                var s = l.Count - 2;
                var e = s - palLen;
                var found = false;
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
