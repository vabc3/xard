using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace xard.test
{
    [TestClass]
    public class CardComboTest
    {
        [TestMethod]
        public void TestDeck()
        {
            var deck = CardCombo.GetDeck();
            Assert.AreEqual(52, deck.Count);
        }
    }
}
