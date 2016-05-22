using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace xard
{
    public class CardType
    {
        public static ReadOnlyCollection<CardType> All { get; private set; }

        static CardType()
        {
            var all = new List<CardType>();
            foreach (var cardSuit in (CardSuit[])Enum.GetValues(typeof(CardSuit)))
            {
                foreach (var cardRank in (CardRank[])Enum.GetValues(typeof(CardRank)))
                {
                    all.Add(new CardType(cardSuit, cardRank));
                }
            }

            All = all.AsReadOnly();
        }

        internal CardType(CardSuit suit, CardRank rank)
        {
            this.Suit = suit;
            this.Rank = rank;
        }

        public CardSuit Suit { get; }
        public CardRank Rank { get; }
    }
}
