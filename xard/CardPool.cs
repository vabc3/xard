using System.Collections.Generic;
using System.Linq;

namespace xard
{
    public class Card
    {
        public int Id { get; set; }
        public CardType Type { get; set; }

        public override string ToString()
            => $"{Id}.{Type.ToCardString()}";
    }

    public class CardPool
    {
        private readonly List<Card> cards;
        public readonly List<CardContainer> containers;

        public CardPool(IEnumerable<Card> cards, List<CardContainer> containers)
        {
            this.cards = cards.ToList();
            this.containers = containers;
            this.containers[0].AddCards(cards);
        }

        public void Transfer(CardContainer from, CardContainer to, params int[] ids)
        {
        }
    }

    public class CardPoolBuilder
    {
        private readonly List<CardType> types = new List<CardType>();
        private readonly List<CardContainer> containers = new List<CardContainer>();

        public CardPoolBuilder()
        {
            this.AddContainer("Bottom");
            this.AddContainer("Ground");
        }

        public void PushDeck()
        {
            this.PushCard(NumbericCardType.All.ToArray());
            this.PushCard(new[] { JokerCardType.Small, JokerCardType.Big });
        }

        public void PushCard(CardType[] cardtypes)
        {
            types.AddRange(cardtypes);
        }

        public void AddContainer(string name)
        {
            containers.Add(new CardContainer { Name = name });
        }

        public CardPool Build()
            => new CardPool(types.Select((t, indexer) => new Card
            {
                Id = indexer,
                Type = t,
            }), containers);
    }

    public class CardContainer
    {
        public string Name { get; set; }
        public List<Card> Cards { get; set; } = new List<Card>();

        public void AddCards(IEnumerable<Card> cards)
        {
            Cards.AddRange(cards);
        }

        public void RemoveCards(IEnumerable<Card> cards)
        {
            foreach (var card in cards)
            {
                if (!Cards.Remove(card))
                {
                    throw new System.InvalidOperationException("Card not in this container");
                }
            }
        }

        public override string ToString()
        {
            return "With " + Cards.Count + " cards";
        }
    }
}
