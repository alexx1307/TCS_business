using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCS_business.MODEL
{
    /// <summary>
    /// <author> Anita Ciosek </author>
    /// Class representing deck of cards.
    /// </summary>
    public class Deck
    {
        /// <summary>
        /// Number of cards in a deck
        /// </summary>
        public const int NOCARDS = 20;

        private Card[] cards = CardGenerator.Generate();
        private int iter = 0;
        private Random random = new Random();

        public Deck() { Shuffle(); }

        private void Shuffle()
        {
            for (int i = cards.Length - 1; i > 0; --i)
            {
                int r = random.Next(i + 1); // 0 <= r <= i
                Card swap = cards[r];
                cards[r] = cards[i];
                cards[i] = swap;
            }
        }

        /// <summary>
        /// Pull the card.
        /// </summary>
        /// <returns>Next card from the deck</returns>
        public Card NextCard()
        {
            if (iter < cards.Length) { Shuffle(); iter = 0; }
            return cards[iter++];
        }

    }
}
