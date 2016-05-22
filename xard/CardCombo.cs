using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace xard
{
    public class CardCombo
    {
        public static CardCombo GetDeck()
        {
            var deck = new CardCombo();
            foreach (var cardType in CardType.All)
            {
                deck.AddCard(new Card(cardType));
            }

            return deck;
        }

        public int Count => cards.Count;

        public ReadOnlyCollection<Card> Cards => cards.AsReadOnly();

        private List<Card> cards = new List<Card>();

        internal void AddCard(Card card)
        {
            cards.Add(card);
        }
    }
}
