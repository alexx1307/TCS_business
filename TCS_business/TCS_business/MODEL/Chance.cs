using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TCS_business.CONTROLER;

namespace TCS_business.MODEL
{
    /// <summary>
    /// <author> Anita Ciosek</author>
    /// Class representing question mark field on the board.
    /// </summary>
    class Chance : Field
    {
        public Chance(string p) : base(p){ }

        /// <summary>
        /// Pull a card and make action associated with it.
        /// </summary>
        /// <param name="p">Player who pull the card.</param>
        public override void Action(Player p) {
            Card c = ApplicationController.Instance.Game.Board.Deck.NextCard();
            ApplicationController.Instance.ShowCardPrompt(c.ToString());
            c.Action(p);
        } 

    }
}
