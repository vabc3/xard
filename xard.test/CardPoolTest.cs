using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace xard.test
{
    [TestClass]
    public class CardPoolTest
    {
        [TestMethod]
        public void TestCardPool()
        {
            var cp = new CardPool();
            var pool = cp.Pool;
            Assert.AreEqual(52, pool.Count);

            var c0 = pool.Cards[0];
            Assert.AreEqual(CardSuit.Pikes, c0.Suit);
            Assert.AreEqual(CardRank.R_A, c0.Rank);

            var c50 = pool.Cards[50];
            Assert.AreEqual(CardSuit.Tiles, c50.Suit);
            Assert.AreEqual(CardRank.R_Q, c50.Rank);
        }
    }
}
