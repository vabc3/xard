namespace xard
{
    public class CardPool
    {
        public CardCombo Pool { get; set; }

        public CardPool()
        {
            this.Pool = CardCombo.GetDeck();
            /*
            for (var i = 0; i < this.Pool.Count; i++)
            {
                this.Pool.Cards[i].SetPoolId(i);
            }
            */
        }

        public void Shuffle()
        {

        }
    }

    /*
    public static class CardPoolExtension
    {
        public static void SetPoolId(this Card card, int id)
        {
            card.Bag.Add("poolId", id);
        }
    }
    */
}
