namespace xard
{
    public class CardType
    {
        internal CardType(CardRank rank, CardSuit suit)
        {
            this.Rank = rank;
            this.Suit = suit;
        }

        public CardRank Rank { get; }
        public CardSuit Suit { get; }
    }
}
