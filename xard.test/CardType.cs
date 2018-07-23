using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace xard
{
    public abstract class CardType
    {
        internal CardType() { }
        public abstract string ToCardString();
    }


    public sealed class JokerCardType : CardType
    {
        public bool Big { get; private set; }
        public JokerCardType(bool big)
        {
            this.Big = big;
        }

        public override string ToCardString()
        {
            int index = 0x1F000 + 0xC0 + 15 + (Big ? 0x10 : 0);
            return char.ConvertFromUtf32(index);
        }
    }

    public sealed class NumbericCardType : CardType
    {
        public static ReadOnlyCollection<NumbericCardType> All { get; private set; }

        static NumbericCardType()
        {
            var all = new List<NumbericCardType>();
            foreach (var cardSuit in (CardSuit[])Enum.GetValues(typeof(CardSuit)))
            {
                foreach (var cardRank in (CardRank[])Enum.GetValues(typeof(CardRank)))
                {
                    all.Add(new NumbericCardType(cardSuit, cardRank));
                }
            }

            All = all.AsReadOnly();
        }

        internal NumbericCardType(CardSuit suit, CardRank rank)
        {
            this.Suit = suit;
            this.Rank = rank;
        }

        public CardSuit Suit { get; }
        public CardRank Rank { get; }

        #region to unicode card string
        public override string ToCardString()
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
        #endregion
    }
}
