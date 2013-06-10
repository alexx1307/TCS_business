using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TCS_business.CONTROLER;

namespace TCS_business.MODEL
{
    /// <summary>
    /// <author>Anita Ciosek</author>
    /// Situation where player has to pay something.
    /// </summary>
    class PayCard : Card
    {
        string description;
        int toPay;
        public PayCard(string s, int i)
        {
            description = s;
            toPay = i;
        }

        public override void Action(Player p)
        {
            p.Cash -= toPay;
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
