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

        public override string ToString()
        {
            int index = 0x1F000;
            switch (this.Suit)
            {
                case CardSuit.Pikes:
                    index += 0xA0;
                    break;
                case CardSuit.Hearts:
                    index += 0xB0;
                    break;
                case CardSuit.Clovers:
                    index += 0xD0;
                    break;
                case CardSuit.Tiles:
                    index += 0xC0;
                    break;
                default:
                    throw new InvalidOperationException();
            }

            switch (this.Rank)
            {
                case CardRank.R_A:
                case CardRank.R_2:
                case CardRank.R_3:
                case CardRank.R_4:
                case CardRank.R_5:
                case CardRank.R_6:
                case CardRank.R_7:
                case CardRank.R_8:
                case CardRank.R_9:
                case CardRank.R_10:
                case CardRank.R_J:
                    index += (int)this.Rank + 1;
                    break;
                case CardRank.R_Q:
                case CardRank.R_K:
                    index += (int)this.Rank + 2;
                    break;
                default:
                    throw new InvalidOperationException();
            }

            return char.ConvertFromUtf32(index);
        }
    }
}
