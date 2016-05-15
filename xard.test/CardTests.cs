using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace xard.test
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void TestCard()
        {
            Card a = new Card(CardRank.R_3, CardSuit.Hearts);
            Assert.AreEqual(CardRank.R_3, a.Rank);
            Assert.AreEqual(CardSuit.Hearts, a.Suit);
        }
    }
}
