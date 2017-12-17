using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRank.Medium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.Medium
{
    [TestClass]
    public class PairsWithDiffTests
    {
        [TestMethod]
        public void TestGet()
        {
            var res = PairsWithDiff.Get(new[] {1, 5, 3, 4, 2}, 2);
            Assert.AreEqual(3, res);
        }
    }
}
