using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace xard.test
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void TestCardType()
        {
            CardType a = new CardType(CardSuit.Hearts, CardRank.R_3);
            Assert.AreEqual(CardRank.R_3, a.Rank);
            Assert.AreEqual(CardSuit.Hearts, a.Suit);
        }

        [TestMethod]
        public void TestCardStr()
        {
            CardType a = new CardType(CardSuit.Hearts, CardRank.R_3);
            var b = new Card(a);
            Assert.AreEqual("🂡", b.ToString());
        }
    }
}
