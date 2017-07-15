using System.Collections.Generic;
using System.Linq;
using HackerRank.Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.Strings
{
    [TestClass]
    public class PalindromSumTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var n = 13;
            var s = "aaaaabbbbaaaa";

            var ps = new MaxPalindrom();
            var res = ps.GetPolindromLength(s, n);
            var stubList = new List<int> { 12, 12, 10, 8, 8, 9, 11, 13, 11, 9, 8, 8, 10};

            Assert.IsTrue(stubList.SequenceEqual(res));
            Assert.IsTrue(stubList.Count == res.Length);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var n = 7;
            var s = "cacbbba";

            var ps = new MaxPalindrom();
            var res = ps.GetPolindromLength(s, n);

            var stubList = new List<int> { 3, 3, 3, 3, 3, 3, 3 };

            Assert.IsTrue(stubList.SequenceEqual(res));
            Assert.IsTrue(stubList.Count == res.Length);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var n = 12;
            var s = "eededdeedede";

            var ps = new MaxPalindrom();
            var res = ps.GetPolindromLength(s, n);

            var stubList = new List<int> { 5, 7, 7, 7, 7, 9, 9, 9, 9, 7, 5, 4 };

            Assert.IsTrue(stubList.SequenceEqual(res));
            Assert.IsTrue(stubList.Count == res.Length);
        }
    }
}
