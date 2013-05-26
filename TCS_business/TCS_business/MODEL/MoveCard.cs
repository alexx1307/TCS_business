using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCS_business.MODEL
{
    /// <summary>
    /// <author>Anita Ciosek</author>
    /// Situation where player move to another field.
    /// </summary>
    class MoveCard : Card
    {
        int field;
        string description;
        public MoveCard(string s, int nr)
        {
            description = s;
            field = nr;
        }

        public override void Action(Player p)
        {
            CONTROLER.ApplicationController.Instance.Game.Board.MovePlayer(field, p);
        }

        /// <summary>
        /// Method used to print the card.
        /// </summary>
        /// <returns>Description of the card</returns>
        public override string ToString()
        {
            return description;
        }
    }
}
