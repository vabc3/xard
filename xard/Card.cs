using System.Collections.Generic;
using System.Text;

namespace xard
{
    public class Card
    {
        public CardSuit Suit => this.type.Suit;

        public CardRank Rand => this.type.Rank;

        private CardType type;

        public IDictionary<string, int> Bag { get; } = new Dictionary<string, int>();

        public Card(CardType type)
        {
            this.type = type;
        }

        public override string ToString()
        {
            return char.ConvertFromUtf32(0x1F0A1);
            //return "\u01F0A1";
        }
    }
}
