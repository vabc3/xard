using System.Collections.Generic;

namespace xard
{
    public class CardPool
    {
        public int Count { get; private set; } = 0;

        private List<ExtendedCard> cards = new List<ExtendedCard>();

        internal void AddCard(Card card)
        {
            this.Count++;
            //cards.Add();
        }

        public void set()
        {
        }
    }
}
