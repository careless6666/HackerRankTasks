using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRank;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests
{
    [TestClass]
    public class SieveEratosfen
    {
        [TestMethod]
        public void CheckSequence()
        {
            var etalon = new List<int> { 1, 2, 3, 5, 7, 11, 13, 17, 19, 23 };
            var res = (new Eratosfen(25)).Simple;

            Assert.IsTrue(etalon.SequenceEqual(res));
            Assert.IsTrue(etalon.Count == res.Length);

        }
    }
}
