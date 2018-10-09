using System.Collections.Generic;
using System.Linq;

namespace Q03
{
    public static class Q03Resolver
    {
        public static int[] Resolve()
        {
            var cards = Enumerable.Range(1, 100).Select(index => new Card(index)).ToArray();

            for (var i = 1; i < cards.Length; i++)
            {
                var multiple = i + 1;
                TurnMultipleCardsOver(multiple, cards);
            }

            return GetFaceUpCardNumbers(cards);
        }

        private static int[] GetFaceUpCardNumbers(IEnumerable<Card> cards)
        {
            return cards.Where(card => card.IsFaceUp)
                .Select(card => card.Index)
                .ToArray();
        }

        private static void TurnMultipleCardsOver(int multiple, IReadOnlyList<Card> cards)
        {
            for (var j = multiple; j < cards.Count; j += multiple)
            {
                cards[j].TurnOver();
            }
        }
    }
}