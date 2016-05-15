namespace xard
{
    public class Card
    {
        public Card(CardRank rank, CardSuit suit)
        {
            this.Rank = rank;
            this.Suit = suit;
        }

        public CardRank Rank { get; }
        public CardSuit Suit { get; }
    }
}
