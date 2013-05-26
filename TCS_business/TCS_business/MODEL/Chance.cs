using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCS_business.MODEL
{
    /// <summary>
    /// <author> Anita Ciosek</author>
    /// Class representing question mark field on the board.
    /// </summary>
    class Chance : Field
    {
        Card[] cards;
        int i;
        public Chance(string p):base(p)
        {
            cards = CardGenerator.Generate();
            i = new Random().Next(0, cards.Length-1);
        }

        /// <summary>
        /// Pull a card and make action associated with it.
        /// </summary>
        /// <param name="p">Player who pull the card.</param>
        public override void Action(Player p) {
            Card c = cards[i % cards.Length];
            ++i;
            c.Action(p);
        } 

    }
}
