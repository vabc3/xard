using System;
using System.Collections.Generic;
using System.Text;

namespace xard
{
    public class Card
    {
        public CardSuit Suit => this.type.Suit;

        public CardRank Rank => this.type.Rank;

        private CardType type;

        public IDictionary<string, int> Bag { get; } = new Dictionary<string, int>();

        public Card(CardType type)
        {
            this.type = type;
        }

        
    }
}
