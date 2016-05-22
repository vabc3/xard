using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace xard.test
{
    [TestClass]
    public class CardTypeTests
    {
        [TestMethod]
        public void TestCardType()
        {
            CardType a = new CardType(CardSuit.Hearts, CardRank.R_3);
            Assert.AreEqual(CardRank.R_3, a.Rank);
            Assert.AreEqual(CardSuit.Hearts, a.Suit);
        }

        [TestMethod]
        public void TestCardTypeStr()
        {
            Assert.AreEqual("🂡", new CardType(CardSuit.Pikes, CardRank.R_A).ToString());
            Assert.AreEqual("🂲", new CardType(CardSuit.Hearts, CardRank.R_2).ToString());
            Assert.AreEqual("🃚", new CardType(CardSuit.Clovers, CardRank.R_10).ToString());
            Assert.AreEqual("🃍", new CardType(CardSuit.Tiles, CardRank.R_Q).ToString());
        }
    }
}
