using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace xard
{
    public class CardCombo
    {
        public static CardCombo GetDeck()
        {
            var deck = new CardCombo();
            foreach (var cardType in NumbericCardType.All)
            {
                deck.AddCard(cardType);
            }

            return deck;
        }

        public int Count => cards.Count;

        public ReadOnlyCollection<NumbericCardType> Cards => cards.AsReadOnly();

        private List<NumbericCardType> cards = new List<NumbericCardType>();

        internal void AddCard(NumbericCardType card)
        {
            cards.Add(card);
        }
    }
}
