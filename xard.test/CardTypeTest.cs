using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace xard.test
{
    [TestClass]
    public class CardTypeTests
    {
        [TestMethod]
        public void TestCardType()
        {
            NumbericCardType a = new NumbericCardType(CardSuit.Hearts, CardRank.R_3);
            Assert.AreEqual(CardRank.R_3, a.Rank);
            Assert.AreEqual(CardSuit.Hearts, a.Suit);
        }

        [TestMethod]
        public void TestCardTypeStr()
        {
            Assert.AreEqual("🂡", new NumbericCardType(CardSuit.Pikes, CardRank.R_A).ToCardString());
            Assert.AreEqual("🂲", new NumbericCardType(CardSuit.Hearts, CardRank.R_2).ToCardString());
            Assert.AreEqual("🃚", new NumbericCardType(CardSuit.Clovers, CardRank.R_10).ToCardString());
            Assert.AreEqual("🃍", new NumbericCardType(CardSuit.Tiles, CardRank.R_Q).ToCardString());

            Assert.AreEqual("🃏", JokerCardType.Small.ToCardString());
            Assert.AreEqual("🃟", JokerCardType.Big.ToCardString());
        }
    }
}
