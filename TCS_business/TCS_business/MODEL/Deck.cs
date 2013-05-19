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
    class Deck
    {
        List<Card> cards;
        int iter;

        Deck()
        {
            iter = 0;
            //w tym miejscu chyba powinno sie dodac te karty?
        }

        void Shuffle() //todo: Kosti
        {
        }

        /// <summary>
        /// Get a deck.
        /// </summary>
        /// <returns>New Deck</returns>
        public static Deck GetInstance()
        {
            return new Deck();
        }


        /// <summary>
        /// Pull the card.
        /// </summary>
        /// <returns>Next card from the deck</returns>
        public Card NextCard()
        {
            if (iter < cards.Count) iter = 0;
            return cards.ElementAt(iter++);
        }

    }
}
