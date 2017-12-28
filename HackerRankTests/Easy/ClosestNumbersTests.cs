using System.Linq;
using HackerRank.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.Easy
{
    [TestClass]
    public class ClosestNumbersTests
    {
        [TestMethod]
        public void TestGetClosest()
        {
            var res = ClosestNumbers.GetClosest(new[] {-20, -3916237, -357920, -3620601, 7374819, -7330761, 30, 6246457, -6461594, 266854});

            Assert.IsTrue(new [] {-20, 30}.SequenceEqual(res));
            
            res = ClosestNumbers.GetClosest(new[] { -20, -3916237, -357920, -3620601, 7374819, -7330761, 30, 6246457, -6461594, 266854, -520, -470 });

            Assert.IsTrue(new[] { -520, -470, -20, 30 }.SequenceEqual(res));

            res = ClosestNumbers.GetClosest(new[] { 5, 4, 3, 2 });
            
            Assert.IsTrue(new[] { 2, 3, 3, 4, 4, 5 }.SequenceEqual(res));
        }
    }
}
