using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCS_business.MODEL
{
    /// <summary>
    /// <author>Anita Ciosek</author>
    /// Situation where player can go out of jail free.
    /// </summary>
    class GoOutFromJailCard : Card
    {
        string description;
        public GoOutFromJailCard()
        {
            description = "Go out of jail free";
        }

        public override void Action(Player p)
        {
            throw new NotImplementedException();
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
