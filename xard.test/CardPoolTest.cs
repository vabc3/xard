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
        }
    }
}
